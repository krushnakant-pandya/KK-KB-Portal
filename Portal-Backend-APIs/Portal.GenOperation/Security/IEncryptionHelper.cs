namespace Portal.GenOperation.Security;

/// <summary>AES-256 symmetric encryption for at-rest sensitive data (e.g. anything beyond password hashes that needs to be recoverable, not just verifiable).</summary>
public interface IEncryptionHelper
{
    string Encrypt(string plainText, string key);

    string Decrypt(string cipherText, string key);
}
