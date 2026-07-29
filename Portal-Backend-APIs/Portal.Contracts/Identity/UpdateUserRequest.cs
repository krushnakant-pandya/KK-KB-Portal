namespace Portal.Contracts.Identity;

public sealed class UpdateUserRequest
{
    public int RoleId { get; init; }
    public string? FullName { get; init; }
    public string? Bio { get; init; }
    public string? ProfileImageUrl { get; init; }
    public bool IsActive { get; init; }
}
