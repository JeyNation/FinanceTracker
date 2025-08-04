namespace FinanceTracker.Contract.Portfolio.Holding;

public record class UpdateHoldingRequest
{
    public string TickerSymbol { get; set; } = string.Empty;
    
    public string CompanyName { get; set; } = string.Empty;

}
