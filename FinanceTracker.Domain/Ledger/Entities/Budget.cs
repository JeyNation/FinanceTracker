using FinanceTracker.Domain.Ledger.Enums;
using FinanceTracker.Domain.Common.Enums;
using FinanceTracker.Domain.Ledger.Exceptions;
using FinanceTracker.Domain.Common.Exceptions;

namespace FinanceTracker.Domain.Ledger.Entities;

public class Budget
{
    public Budget(
        Guid userId,
        decimal limitAmount,
        Currency currency = Currency.CAD,
        ActivityType activityType = ActivityType.Miscellaneous,
        BudgetDuration duration = BudgetDuration.Monthly)
    {
        ValidateLimitAmount(limitAmount);
        Id = Guid.NewGuid();
        UserId = userId;
        LimitAmount = limitAmount;
        Currency = currency;
        ActivityType = activityType;
        Duration = duration;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
        IsActive = true;
    }

    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public decimal LimitAmount { get; private set; }
    public Currency Currency { get; private set; }
    public ActivityType ActivityType { get; private set; }
    public BudgetDuration Duration { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public bool IsActive { get; private set; }

    public void UpdateLimitAmount(decimal newLimit)
    {
        ValidateLimitAmount(newLimit);
        LimitAmount = newLimit;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateCurrency(Currency currency)
    {
        Currency = currency;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateActivityType(ActivityType activityType)
    {
        ActivityType = activityType;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateDuration(BudgetDuration duration)
    {
        Duration = duration;
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
    
    private void ValidateLimitAmount(decimal limitAmount)
    {
        if (limitAmount <= 0)
            throw new InvalidValueException(limitAmount, "Limit amount must be positive.");
    }
}
