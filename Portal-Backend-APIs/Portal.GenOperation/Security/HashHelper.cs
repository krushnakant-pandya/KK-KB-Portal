using System.Security.Cryptography;
using System.Text;

namespace Portal.GenOperation.Security;

public sealed class HashHelper : IHashHelper
{
    public string Sha256(string value) =>
        Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(value))).ToLowerInvariant();

    public string HmacSha256(string value, string key) =>
        Convert.ToHexString(HMACSHA256.HashData(Encoding.UTF8.GetBytes(key), Encoding.UTF8.GetBytes(value))).ToLowerInvariant();
}
