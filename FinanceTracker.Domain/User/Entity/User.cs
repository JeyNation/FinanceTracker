using System.ComponentModel;
using FinanceTracker.Domain.Common.Exceptions;
using FinanceTracker.Domain.User.Exceptions;
using FinanceTracker.Domain.User.ValueObjects;

namespace FinanceTracker.Domain.User.Entity;

public class User
{
    public User(
        UserName userName,
        Email email,
        FullName fullName,
        string passwordHash)
    {
        Id = Guid.NewGuid();
        UserName = userName;
        Email = email;
        FullName = fullName;
        PasswordHash = passwordHash;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
        IsActive = true;
    }

    public Guid Id { get; private set; }
    public UserName UserName { get; private set; }
    public Email Email { get; private set; }
    public FullName FullName { get; private set; }
    public string PasswordHash { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public bool IsActive { get; private set; }

    public void UpdateUserName(UserName userName)
    {
        UserName = userName;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateEmail(Email email)
    {
        Email = email;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateFullName(FullName fullName)
    {
        FullName = fullName;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdatePasswordHash(string passwordHash)
    {
        PasswordHash = passwordHash;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Deactivate()
    {
        if (!IsActive)
            return;

        IsActive = false;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Activate()
    {
        if (IsActive)
            return;

        IsActive = true;
        UpdatedAt = DateTime.UtcNow;
    }
}
