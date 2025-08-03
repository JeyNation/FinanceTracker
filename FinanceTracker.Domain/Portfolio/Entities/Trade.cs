using FinanceTracker.Domain.Common.Exceptions;
using FinanceTracker.Domain.Portfolio.Enums;

namespace FinanceTracker.Domain.Portfolio.Entities;

public class Trade
{
    public Trade(
        Guid userId,
        Guid holdingId,
        TradeType type,
        decimal quantity,
        decimal costPerShare,
        decimal fee = 0.0m,
        Guid? transactionId = null,
        DateTime? date = null)
    {
        ValidateQuantity(quantity);
        ValidateCostPerShare(costPerShare);
        ValidateFee(fee);

        Id = Guid.NewGuid();
        UserId = userId;
        HoldingId = holdingId;
        Type = type;
        Quantity = quantity;
        CostPerShare = costPerShare;
        Fee = fee;
        TransactionId = transactionId;
        Date = date ?? DateTime.UtcNow;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
        IsActive = true;
    }

    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public Guid HoldingId { get; private set; }
    public Guid? TransactionId { get; private set; }
    public TradeType Type { get; private set; }
    public decimal Quantity { get; private set; }
    public decimal CostPerShare { get; private set; }
    public decimal Fee { get; private set; }
    public DateTime Date { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public bool IsActive { get; private set; }

    public void UpdateQuantity(decimal quantity)
    {
        ValidateQuantity(quantity);
        Quantity = quantity;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateCostPerShare(decimal costPerShare)
    {
        ValidateCostPerShare(costPerShare);
        CostPerShare = costPerShare;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateFee(decimal fee)
    {
        ValidateFee(fee);
        Fee = fee;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateType(TradeType type)
    {
        Type = type;
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

    private void ValidateQuantity(decimal quantity)
    {
        if (quantity <= 0)
            throw new InvalidValueException(quantity, "Quantity must be positive.");
    }

    private void ValidateCostPerShare(decimal costPerShare)
    {
        if (costPerShare < 0)
            throw new InvalidValueException(costPerShare, "Cost per share cannot be negative.");
    }

    private void ValidateFee(decimal fee)
    {
        if (fee < 0)
            throw new InvalidValueException(fee, "Fee cannot be negative.");
    }
}
