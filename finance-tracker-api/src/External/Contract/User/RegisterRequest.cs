namespace FinanceTracker.Contract.User;

public record class RegisterRequest
{
    public string Email { get; init; } = string.Empty; // The email address of the user
    public string UserName { get; init; } = string.Empty; // The username for the user account
    public string FirstName { get; init; } = string.Empty; // The first name of the user
    public string LastName { get; init; } = string.Empty; // The last name
    public string Password { get; init; } = string.Empty; // The password for the user account
    public string ConfirmPassword { get; init; } = string.Empty; // The confirmation password for the user account
}
