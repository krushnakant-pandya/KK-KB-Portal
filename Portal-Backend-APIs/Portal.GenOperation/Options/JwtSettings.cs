namespace Portal.GenOperation.Options;

/// <summary>Bound from the "Jwt" configuration section.</summary>
public sealed class JwtSettings
{
    public const string SectionName = "Jwt";

    /// <summary>Symmetric signing key — must be at least 256 bits (32 chars) for HS256. Set via user-secrets/environment, never committed.</summary>
    public string SigningKey { get; set; } = string.Empty;

    public string Issuer { get; set; } = "KbPortal";
    public string Audience { get; set; } = "KbPortal.Client";
    public int AccessTokenMinutes { get; set; } = 15;
    public int RefreshTokenDays { get; set; } = 7;
}
