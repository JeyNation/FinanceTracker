namespace FinanceTracker.Contract.Ledger.Activity;

public record class TransferMoneyRequest
{
    public string AccountId { get; init; } = string.Empty; // The ID of the account to which the transfer is made
    public decimal Amount { get; init; }
    public string CurrencyCode { get; init; } = string.Empty; // e.g., "USD", "CAD"
    public DateTime Date { get; init; } = DateTime.UtcNow;
}
