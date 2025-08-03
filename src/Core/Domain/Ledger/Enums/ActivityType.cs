using System;

namespace FinanceTracker.Domain.Ledger.Enums;

public enum ActivityType
{
    // Income
    Salary,
    Bonus,
    Interest,
    Dividend,
    InvestmentIncome,
    RentalIncome,
    Gift,
    Refund,
    Sale,
    OtherIncome,

    // Expenses
    Rent,
    Mortgage,
    Utilities,
    Groceries,
    Transportation,
    Insurance,
    Healthcare,
    Education,
    Childcare,
    Entertainment,
    Dining,
    Clothing,
    PersonalCare,
    Subscriptions,
    Travel,
    Taxes,
    LoanPayment,
    Savings,
    Investment,
    Charity,
    Miscellaneous
}
