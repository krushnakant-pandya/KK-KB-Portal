namespace Portal.GenOperation.Documents;

/// <summary>
/// <para>Placeholder for generating QR codes (e.g. linking a printed KB page back to its URL).</para>
/// <remarks>Not implemented — wire up QRCoder when this is needed.</remarks>
/// </summary>
public interface IQrCodeHelper
{
    byte[] GenerateQrCode(string content, int pixelsPerModule = 20);
}
