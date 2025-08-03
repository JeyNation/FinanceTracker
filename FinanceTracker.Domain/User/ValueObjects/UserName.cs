using FinanceTracker.Domain.User.Exceptions;

namespace FinanceTracker.Domain.User.ValueObjects;

public sealed class UserName
{
    public string Value { get; }

    public UserName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidUserNameException(value ?? "");

        // Only allow letters, numbers, underscores, and no spaces, 3-20 chars
        var pattern = @"^[A-Za-z0-9_]{3,20}$";
        if (!System.Text.RegularExpressions.Regex.IsMatch(value, pattern))
            throw new InvalidUserNameException(value, "Username must be 3-20 characters and can only contain letters, numbers, and underscores.");

        Value = value;
    }

    public override string ToString() => Value;

    public override bool Equals(object? obj) =>
        obj is UserName other && Value.Equals(other.Value, StringComparison.Ordinal);

    public override int GetHashCode() => Value.GetHashCode();

    public static implicit operator string(UserName userName) => userName.Value;
}