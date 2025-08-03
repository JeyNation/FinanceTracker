using FinanceTracker.Domain.Common.Exceptions;

namespace FinanceTracker.Domain.User.Exceptions;

public class InvalidEmailException : DomainException
{
    public InvalidEmailException(string email)
        : base($"Email '{email}' is invalid.") { }

    public InvalidEmailException(string email, string message)
        : base($"Email '{email}' is invalid. {message}") { }
}
