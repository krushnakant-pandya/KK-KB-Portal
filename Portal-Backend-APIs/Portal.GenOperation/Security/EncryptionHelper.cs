using System.Security.Cryptography;
using System.Text;

namespace Portal.GenOperation.Security;

/// <summary>AES-256-GCM (authenticated encryption) — the key string is SHA-256-hashed to derive a 256-bit key, so callers can pass any-length passphrase. Output is base64(nonce + tag + ciphertext).</summary>
public sealed class EncryptionHelper : IEncryptionHelper
{
    private const int NonceSizeBytes = 12;
    private const int TagSizeBytes = 16;

    public string Encrypt(string plainText, string key)
    {
        var keyBytes = DeriveKey(key);
        var plainBytes = Encoding.UTF8.GetBytes(plainText);

        var nonce = RandomNumberGenerator.GetBytes(NonceSizeBytes);
        var cipherBytes = new byte[plainBytes.Length];
        var tag = new byte[TagSizeBytes];

        using var aesGcm = new AesGcm(keyBytes, TagSizeBytes);
        aesGcm.Encrypt(nonce, plainBytes, cipherBytes, tag);

        var result = new byte[NonceSizeBytes + TagSizeBytes + cipherBytes.Length];
        Buffer.BlockCopy(nonce, 0, result, 0, NonceSizeBytes);
        Buffer.BlockCopy(tag, 0, result, NonceSizeBytes, TagSizeBytes);
        Buffer.BlockCopy(cipherBytes, 0, result, NonceSizeBytes + TagSizeBytes, cipherBytes.Length);

        return Convert.ToBase64String(result);
    }

    public string Decrypt(string cipherText, string key)
    {
        var keyBytes = DeriveKey(key);
        var data = Convert.FromBase64String(cipherText);

        var nonce = data.AsSpan(0, NonceSizeBytes);
        var tag = data.AsSpan(NonceSizeBytes, TagSizeBytes);
        var cipherBytes = data.AsSpan(NonceSizeBytes + TagSizeBytes);

        var plainBytes = new byte[cipherBytes.Length];
        using var aesGcm = new AesGcm(keyBytes, TagSizeBytes);
        aesGcm.Decrypt(nonce, cipherBytes, tag, plainBytes);

        return Encoding.UTF8.GetString(plainBytes);
    }

    private static byte[] DeriveKey(string key) => SHA256.HashData(Encoding.UTF8.GetBytes(key));
}
