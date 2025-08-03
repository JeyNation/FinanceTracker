namespace FinanceTracker.Domain.Ledger.Enums;

public enum TransactionType
{
    Debit, // For expenses or withdrawals
    Credit, // For income or refunds
    Transfer, // For transfers between accounts
    Trade, // For stock trades, etc.
}
