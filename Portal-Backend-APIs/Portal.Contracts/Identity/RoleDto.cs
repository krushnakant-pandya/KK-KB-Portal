namespace Portal.Contracts.Identity;

public sealed class RoleDto
{
    public int RoleId { get; init; }
    public string RoleName { get; init; } = string.Empty;
    public string? Description { get; init; }
}
