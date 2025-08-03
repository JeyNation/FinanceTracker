namespace FinanceTracker.Domain.Common.Exceptions;

public class InvalidValueException : DomainException
{
    public InvalidValueException(object value)
        : base($"The value '{value}' is invalid.")
    {
    }

    public InvalidValueException(object value, string message)
        : base($"The value '{value}' is invalid. {message}")
    {
    }
}
