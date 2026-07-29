namespace Portal.GenOperation.Documents;

public sealed class QrCodeHelper : IQrCodeHelper
{
    public byte[] GenerateQrCode(string content, int pixelsPerModule = 20) =>
        throw new NotImplementedException("QR code generation is not implemented. Add the QRCoder package and implement this method when needed.");
}
