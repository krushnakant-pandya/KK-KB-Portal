namespace Portal.GenOperation.Security;

/// <summary>BCrypt password hashing — the only correct way to store user credentials (salted, slow-by-design, verify-only).</summary>
public interface IPasswordHelper
{
    string Hash(string password);

    bool Verify(string password, string hash);
}
