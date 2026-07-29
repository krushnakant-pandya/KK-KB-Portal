namespace Portal.Contracts.Identity;

/// <summary>Lightweight projection for user list/search endpoints — omits Bio/ProfileImageUrl to keep list payloads small.</summary>
public sealed class UserListItemDto
{
    public int UserId { get; init; }
    public string Username { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string RoleName { get; init; } = string.Empty;
    public bool IsActive { get; init; }
    public DateTime CreatedAt { get; init; }
}
