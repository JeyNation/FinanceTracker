using FinanceTracker.Domain.Ledger.Enums;
using FinanceTracker.Domain.Common.Enums;
using FinanceTracker.Domain.Ledger.Exceptions;
using FinanceTracker.Domain.Common.Exceptions;

namespace FinanceTracker.Domain.Ledger.Entity;

public class Account
{
    public Account(
        Guid userId,
        string name,
        decimal initialBalance = 0.0m,
        AccountType accountType = AccountType.Checking,
        Currency currency = Currency.CAD)
    {
        ValidateName(name);
        ValidateAmount(initialBalance, "Initial balance must be non-negative.");
        Id = Guid.NewGuid();
        UserId = userId;
        Name = name;
        Balance = initialBalance;
        AccountType = accountType;
        Currency = currency;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
        IsActive = true;
    }

    public Guid Id { get; private set; }

    public Guid UserId { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public decimal Balance { get; private set; } = 0.0m;

    public AccountType AccountType { get; private set; } = AccountType.Checking;

    public Currency Currency { get; private set; } = Currency.CAD;

    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;

    public bool IsActive { get; private set; } = true;

    public void UpdateName(string name)
    {
        ValidateName(name);

        Name = name;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateAccountType(AccountType accountType)
    {
        AccountType = accountType;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateCurrency(Currency currency)
    {
        Currency = currency;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Deposit(decimal amount)
    {
        ValidateAmount(amount, "Deposit amount must be positive.");

        Balance += amount;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Withdraw(decimal amount)
    {
        ValidateAmount(amount, "Withdrawal amount must be positive.");

        if (amount > Balance)
            throw new InsufficientFundsException(amount, Balance);

        Balance -= amount;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Deactivate()
    {
        if (!IsActive)
            return;

        IsActive = false;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Activate()
    {
        if (IsActive)
            return;

        IsActive = true;
        UpdatedAt = DateTime.UtcNow;
    }

    private void ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new InvalidValueException(name, "Account name cannot be empty.");
    }

    private void ValidateAmount(decimal amount, string message)
    {
        if (amount <= 0)
            throw new InvalidValueException(amount, message);
    }
}
