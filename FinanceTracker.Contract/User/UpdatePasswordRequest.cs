namespace FinanceTracker.Contract.User;

public record class UpdatePasswordRequest
{
    public string Password { get; init; } = string.Empty; // The password for the user account
    public string ConfirmPassword { get; init; } = string.Empty; // The confirmation password for the user account
}
