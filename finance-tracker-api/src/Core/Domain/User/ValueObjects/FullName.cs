using System.Text.RegularExpressions;
using FinanceTracker.Domain.User.Exceptions;

namespace FinanceTracker.Domain.User.ValueObjects;

public sealed class FullName
{
    public string FirstName { get; }
    public string LastName { get; }
    private const int MinLength = 1;
    private const int MaxLength = 50;

    public FullName(string firstName, string lastName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new InvalidFullNameException(firstName, lastName, "First name cannot be empty.");

        if (string.IsNullOrWhiteSpace(lastName))
            throw new InvalidFullNameException(firstName, lastName, "Last name cannot be empty.");

        if (firstName.Length < MinLength || firstName.Length > MaxLength)
            throw new InvalidFullNameException(firstName, lastName, $"First name must be between {MinLength} and {MaxLength} characters.");

        if (lastName.Length < MinLength || lastName.Length > MaxLength)
            throw new InvalidFullNameException(firstName, lastName, $"Last name must be between {MinLength} and {MaxLength} characters.");

        // Allow Unicode letters, spaces, and hyphens
        var pattern = @"^[\p{L}\s-]+$";
        if (!Regex.IsMatch(firstName, pattern))
            throw new InvalidFullNameException(firstName, lastName, "First name can only contain letters, spaces, and hyphens.");

        if (!Regex.IsMatch(lastName, pattern))
            throw new InvalidFullNameException(firstName, lastName, "Last name can only contain letters, spaces, and hyphens.");

        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString() => $"{FirstName} {LastName}";

    public override bool Equals(object? obj) =>
        obj is FullName other && FirstName.Equals(other.FirstName, StringComparison.Ordinal) && LastName.Equals(other.LastName, StringComparison.Ordinal);

    public override int GetHashCode() => HashCode.Combine(FirstName, LastName);
}
