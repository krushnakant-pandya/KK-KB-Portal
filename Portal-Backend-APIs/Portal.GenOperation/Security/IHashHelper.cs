namespace Portal.GenOperation.Security;

/// <summary>One-way hashing for non-password data (e.g. deduplication fingerprints, HMAC-signed webhook payloads). Use IPasswordHelper for credentials.</summary>
public interface IHashHelper
{
    string Sha256(string value);

    string HmacSha256(string value, string key);
}
