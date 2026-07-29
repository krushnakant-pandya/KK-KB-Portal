using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Portal.GenOperation.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Portal.GenOperation.Security;

public sealed class JwtHelper(IOptions<JwtSettings> options) : IJwtHelper
{
    private readonly JwtSettings _settings = options.Value;

    public (string Token, DateTime ExpiresAt) GenerateAccessToken(IEnumerable<Claim> claims)
    {
        var expiresAt = DateTime.UtcNow.AddMinutes(_settings.AccessTokenMinutes);
        var credentials = new SigningCredentials(SigningKey, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _settings.Issuer,
            audience: _settings.Audience,
            claims: claims,
            expires: expiresAt,
            signingCredentials: credentials);

        return (new JwtSecurityTokenHandler().WriteToken(token), expiresAt);
    }

    public string GenerateRefreshToken() => Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));

    public ClaimsPrincipal? ValidateToken(string token)
    {
        try
        {
            var handler = new JwtSecurityTokenHandler();
            var principal = handler.ValidateToken(token, ValidationParameters(validateLifetime: true), out _);
            return principal;
        }
        catch (SecurityTokenException)
        {
            return null;
        }
    }

    public ClaimsPrincipal? GetPrincipalFromExpiredToken(string token)
    {
        try
        {
            var handler = new JwtSecurityTokenHandler();
            var principal = handler.ValidateToken(token, ValidationParameters(validateLifetime: false), out var securityToken);

            if (securityToken is not JwtSecurityToken jwtToken ||
                !jwtToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.OrdinalIgnoreCase))
            {
                return null;
            }

            return principal;
        }
        catch (SecurityTokenException)
        {
            return null;
        }
    }

    private SymmetricSecurityKey SigningKey => new(Encoding.UTF8.GetBytes(_settings.SigningKey));

    private TokenValidationParameters ValidationParameters(bool validateLifetime) => new()
    {
        ValidateIssuer = true,
        ValidIssuer = _settings.Issuer,
        ValidateAudience = true,
        ValidAudience = _settings.Audience,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = SigningKey,
        ValidateLifetime = validateLifetime,
        ClockSkew = TimeSpan.FromSeconds(30),
    };
}
