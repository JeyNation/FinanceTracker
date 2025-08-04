namespace FinanceTracker.Contract.Ledger.Budget;

public record class UpdateBudgetRequest
{
    public decimal LimitAmount { get; init; }
    public string CurrencyCode { get; init; } = string.Empty; // e.g., "USD", "CAD"
    public string CategoryName { get; init; } = string.Empty; // e.g., "Groceries", "Utilities"
    public string Duration { get; init; } = string.Empty; // e.g., "Monthly", "Yearly", "Weekly"
}
