namespace FinanceTracker.Contract.User;

public record class UpdateProfileRequest
{
    public string Email { get; init; } = string.Empty; // The email address of the user
    public string FirstName { get; init; } = string.Empty; // The first name of the user
    public string LastName { get; init; } = string.Empty; // The last name of the user
}
