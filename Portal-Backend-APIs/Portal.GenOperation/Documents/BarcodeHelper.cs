namespace Portal.GenOperation.Documents;

public sealed class BarcodeHelper : IBarcodeHelper
{
    public byte[] GenerateBarcode(string content, int width = 300, int height = 100) =>
        throw new NotImplementedException("Barcode generation is not implemented. Add the ZXing.Net package and implement this method when needed.");
}
