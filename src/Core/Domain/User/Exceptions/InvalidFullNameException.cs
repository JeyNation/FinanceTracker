using FinanceTracker.Domain.Common.Exceptions;

namespace FinanceTracker.Domain.User.Exceptions;

public class InvalidFullNameException : DomainException
{
    public InvalidFullNameException(string firstName, string lastName)
        : base($"Invalid full name '{firstName} {lastName}': Invalid format.")
    {
    }

    public InvalidFullNameException(string firstName, string lastName, string message)
        : base($"Invalid name '{firstName} {lastName}': {message}")
    {
    }
}