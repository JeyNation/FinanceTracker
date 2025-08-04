namespace FinanceTracker.Contract.Portfolio.Holding;

public record class CreateHoldingRequest
{
    public string TickerSymbol { get; init; } = string.Empty;

    public string CompanyName { get; init; } = string.Empty;

    public string CurrencyCode { get; init; } = "CAD"; // Default to CAD
}
