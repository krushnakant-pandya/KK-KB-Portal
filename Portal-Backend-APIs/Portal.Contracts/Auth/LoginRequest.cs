namespace Portal.Contracts.Auth;

public sealed class LoginRequest
{
    /// <summary>Accepts either the Username or the Email — resolved via IUserRepository.GetByUsernameOrEmailAsync.</summary>
    public string UsernameOrEmail { get; init; } = string.Empty;

    public string Password { get; init; } = string.Empty;
}
