using FinanceTracker.Domain.Common.Exceptions;

namespace FinanceTracker.Domain.User.Exceptions;

public class InvalidUserNameException : DomainException
{
    public InvalidUserNameException(string userName)
        : base($"Username '{userName}' is invalid.")
    { }

    public InvalidUserNameException(string userName, string message)
        : base($"Username '{userName}' is invalid. {message}")
    { }
}