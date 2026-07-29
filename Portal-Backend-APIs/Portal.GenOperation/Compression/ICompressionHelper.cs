namespace Portal.GenOperation.Compression;

public interface ICompressionHelper
{
    byte[] GzipCompress(byte[] data);

    byte[] GzipDecompress(byte[] data);

    byte[] BrotliCompress(byte[] data);

    byte[] BrotliDecompress(byte[] data);
}
