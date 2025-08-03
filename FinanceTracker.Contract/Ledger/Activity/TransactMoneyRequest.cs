namespace FinanceTracker.Contract.Ledger.Activity;

public record class TransactMoneyRequest
{
    public decimal Amount { get; init; } // The amount of money
    public string CurrencyCode { get; init; } = string.Empty; // e.g., "USD", "CAD"
    public string Category { get; init; } = string.Empty; // The category of the transaction, e.g., "Salary", "Bonus", "Interest"
    public DateTime Date { get; init; } = DateTime.UtcNow; // The date the money transaction was received
}
