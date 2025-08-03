namespace FinanceTracker.Domain.Ledger.Enums;

public enum ExpenseType
{
    Fixed, // Regular, unchanging expenses (e.g., rent, mortgage, insurance)
    Variable, // Essential but fluctuating expenses (e.g., groceries, utilities, transportation)
    Discretionary, // Non-essential expenses (e.g., dining out, entertainment, luxury items)
    Saving, // Setting aside money for future goals (e.g., emergency fund, retirement)
    Debt, // Payments made towards reducing outstanding debt (e.g., credit card payments, loans)
    Investment, // Expenditures aimed at generating returns (e.g., stocks, bonds, real estate)
}
