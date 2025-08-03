namespace FinanceTracker.Contract.Ledger.Portfolio.Activity;

public record class TradeRequest
{
    public string TickerSymbol { get; init; } = string.Empty; // The asset being traded (e.g., "AAPL", "BTC")
    public decimal Quantity { get; init; } // The quantity of the asset being traded
    public decimal CostPerPrice { get; init; } // The price at which the asset is being traded
    public decimal Fee { get; set; } // The fee associated with the trade
    public DateTime Date { get; init; } = DateTime.UtcNow;
}
