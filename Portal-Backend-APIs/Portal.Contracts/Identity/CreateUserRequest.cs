namespace Portal.Contracts.Identity;

public sealed class CreateUserRequest
{
    public int RoleId { get; init; }
    public string Username { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
    public string? FullName { get; init; }
    public string? Bio { get; init; }
    public string? ProfileImageUrl { get; init; }
}
