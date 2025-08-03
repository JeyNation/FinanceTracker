namespace FinanceTracker.Contract.Ledger.Account;

public record class CreateAccountRequest
{
    public string Name { get; init; } = string.Empty;
    public decimal InitialBalance { get; init; }
    public string AccountType { get; init; } = string.Empty;
    public string CurrencyCode { get; init; } = string.Empty;
}
