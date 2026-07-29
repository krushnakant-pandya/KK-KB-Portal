namespace Portal.Contracts.Identity;

public sealed class UserDto
{
    public int UserId { get; init; }
    public string Username { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string RoleName { get; init; } = string.Empty;
    public string? FullName { get; init; }
    public string? Bio { get; init; }
    public string? ProfileImageUrl { get; init; }
    public bool IsActive { get; init; }
    public bool IsEmailVerified { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime? LastLoginAt { get; init; }
}
