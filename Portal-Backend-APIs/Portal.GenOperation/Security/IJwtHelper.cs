using System.Security.Claims;

namespace Portal.GenOperation.Security;

public interface IJwtHelper
{
    (string Token, DateTime ExpiresAt) GenerateAccessToken(IEnumerable<Claim> claims);

    string GenerateRefreshToken();

    /// <summary>Validates signature and expiry — returns null for anything invalid rather than throwing, so callers can treat auth failures uniformly.</summary>
    ClaimsPrincipal? ValidateToken(string token);

    /// <summary>Extracts claims from an access token whose signature is valid but which has expired — used by the refresh-token flow to identify who is refreshing.</summary>
    ClaimsPrincipal? GetPrincipalFromExpiredToken(string token);
}
