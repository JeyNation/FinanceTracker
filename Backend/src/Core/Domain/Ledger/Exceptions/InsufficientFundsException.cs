using FinanceTracker.Domain.Common.Exceptions;

namespace FinanceTracker.Domain.Ledger.Exceptions;

public class InsufficientFundsException : DomainException
{
    public InsufficientFundsException(decimal attemptedAmount, decimal availableBalance)
        : base($"Insufficient funds: attempted to use {attemptedAmount}, but only {availableBalance} is available.") { }
}