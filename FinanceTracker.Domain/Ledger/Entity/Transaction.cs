using FinanceTracker.Domain.Ledger.Enums;
using FinanceTracker.Domain.Common.Enums;
using FinanceTracker.Domain.Common.Exceptions;

namespace FinanceTracker.Domain.Ledger.Entity;

public class Transaction
{
    public Transaction(
        Guid userId,
        Guid accountId,
        decimal amount,
        Currency currency,
        ActivityType activityType,
        TransactionType transactionType,
        DateTime date,
        string description = "")
    {
        ValidateAmount(amount);
        Id = Guid.NewGuid();
        UserId = userId;
        AccountId = accountId;
        Amount = amount;
        Currency = currency;
        ActivityType = activityType;
        TransactionType = transactionType;
        Date = date;
        Description = description;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
        IsActive = true;
    }

    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public Guid AccountId { get; private set; }
    public string Description { get; private set; }
    public decimal Amount { get; private set; }
    public Currency Currency { get; private set; }
    public ActivityType ActivityType { get; private set; }
    public TransactionType TransactionType { get; private set; }
    public DateTime Date { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public bool IsActive { get; private set; }

    public void UpdateAmount(decimal amount)
    {
        ValidateAmount(amount);
        Amount = amount;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateDescription(string description)
    {
        Description = description ?? string.Empty;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateActivityType(ActivityType activityType)
    {
        ActivityType = activityType;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateTransactionType(TransactionType transactionType)
    {
        TransactionType = transactionType;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateCurrency(Currency currency)
    {
        Currency = currency;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateDate(DateTime date)
    {
        Date = date;
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

    private void ValidateAmount(decimal amount)
    {
        if (amount <= 0)
            throw new InvalidValueException(amount, "Amount must be positive.");
    }
}
