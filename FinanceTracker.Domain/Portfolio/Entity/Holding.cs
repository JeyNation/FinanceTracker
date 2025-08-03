using FinanceTracker.Domain.Common.Enums;
using FinanceTracker.Domain.Common.Exceptions;

namespace FinanceTracker.Domain.Portfolio.Entity;

public class Holding
{
    public Holding(
        Guid userId,
        Guid accountId,
        string tickerSymbol,
        string companyName,
        decimal quantity,
        decimal averagePurchasePrice,
        Currency currency = Currency.CAD)
    {
        ValidateQuantity(quantity);
        ValidateAveragePurchasePrice(averagePurchasePrice);

        Id = Guid.NewGuid();
        UserId = userId;
        AccountId = accountId;
        TickerSymbol = tickerSymbol;
        CompanyName = companyName;
        Quantity = quantity;
        AveragePurchasePrice = averagePurchasePrice;
        Currency = currency;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
        IsActive = true;
    }

    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public Guid AccountId { get; private set; }
    public Currency Currency { get; private set; }
    public string TickerSymbol { get; private set; }
    public string CompanyName { get; private set; }
    public decimal Quantity { get; private set; }
    public decimal AveragePurchasePrice { get; private set; }
    public List<Trade> Trades { get; private set; } = new List<Trade>();
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public bool IsActive { get; private set; }

    public void UpdateQuantity(decimal quantity)
    {
        ValidateQuantity(quantity);
        Quantity = quantity;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateAveragePurchasePrice(decimal price)
    {
        ValidateAveragePurchasePrice(price);
        AveragePurchasePrice = price;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateCompanyName(string companyName)
    {
        CompanyName = companyName ?? string.Empty;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateTickerSymbol(string tickerSymbol)
    {
        TickerSymbol = tickerSymbol ?? string.Empty;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateCurrency(Currency currency)
    {
        Currency = currency;
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
        if (quantity < 0)
            throw new InvalidValueException(quantity, "Quantity cannot be negative.");
    }

    private void ValidateAveragePurchasePrice(decimal price)
    {
        if (price < 0)
            throw new InvalidValueException(price, "Average purchase price cannot be negative.");
    }
}