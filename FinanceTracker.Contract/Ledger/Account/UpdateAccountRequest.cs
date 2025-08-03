namespace FinanceTracker.Contract.Ledger.Account;

public record class UpdateAccountRequest
{
    public string Name { get; init; } = string.Empty;
    public decimal Balance { get; init; }
    public string AccountType { get; init; } = string.Empty;
    public string CurrencyCode { get; init; } = string.Empty;
}
