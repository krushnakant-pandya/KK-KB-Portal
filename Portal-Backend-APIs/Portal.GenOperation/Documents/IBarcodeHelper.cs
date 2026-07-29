namespace Portal.GenOperation.Documents;

/// <summary>
/// <para>Placeholder for generating 1D/2D barcodes.</para>
/// <remarks>Not implemented — wire up ZXing.Net when this is needed.</remarks>
/// </summary>
public interface IBarcodeHelper
{
    byte[] GenerateBarcode(string content, int width = 300, int height = 100);
}
