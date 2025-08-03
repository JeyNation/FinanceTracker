using FinanceTracker.Domain.Common.Exceptions;
using FinanceTracker.Domain.Ledger.Exceptions;

namespace FinanceTracker.Domain.Ledger.Entity;

public class Transfer
{
    public Transfer(
        Guid userId,
        Guid fromTransactionId,
        Guid toTransactionId,
        decimal exchangeRate = 1.0m,
        decimal fee = 0.0m,
        DateTime? date = null)
    {
        ValidateAmount(exchangeRate, "Exchange rate must be positive.");
        ValidateAmount(fee, "Fee cannot be negative.");
        Id = Guid.NewGuid();
        UserId = userId;
        FromTransactionId = fromTransactionId;
        ToTransactionId = toTransactionId;
        ExchangeRate = exchangeRate;
        Fee = fee;
        Date = date ?? DateTime.UtcNow;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
        IsActive = true;
    }

    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public Guid FromTransactionId { get; private set; }
    public Guid ToTransactionId { get; private set; }
    public decimal ExchangeRate { get; private set; } = 1.0m;
    public decimal Fee { get; private set; } = 0.0m;
    public DateTime Date { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public bool IsActive { get; private set; }

    public void UpdateExchangeRate(decimal exchangeRate)
    {
        ValidateAmount(exchangeRate, "Exchange rate must be positive.");
        ExchangeRate = exchangeRate;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateFee(decimal fee)
    {
        ValidateAmount(fee, "Fee cannot be negative.");
        Fee = fee;
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

    private void ValidateAmount(decimal amount, string errorMessage)
    {
        if (amount < 0)
            throw new InvalidValueException(amount, errorMessage);
    }
}
