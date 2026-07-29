using System.IO.Compression;

namespace Portal.GenOperation.Compression;

public sealed class CompressionHelper : ICompressionHelper
{
    public byte[] GzipCompress(byte[] data) => Compress(data, s => new GZipStream(s, CompressionLevel.Optimal));

    public byte[] GzipDecompress(byte[] data) => Decompress(data, s => new GZipStream(s, CompressionMode.Decompress));

    public byte[] BrotliCompress(byte[] data) => Compress(data, s => new BrotliStream(s, CompressionLevel.Optimal));

    public byte[] BrotliDecompress(byte[] data) => Decompress(data, s => new BrotliStream(s, CompressionMode.Decompress));

    private static byte[] Compress(byte[] data, Func<MemoryStream, Stream> streamFactory)
    {
        using var output = new MemoryStream();
        using (var compressionStream = streamFactory(output))
        {
            compressionStream.Write(data, 0, data.Length);
        }

        return output.ToArray();
    }

    private static byte[] Decompress(byte[] data, Func<MemoryStream, Stream> streamFactory)
    {
        using var input = new MemoryStream(data);
        using var decompressionStream = streamFactory(input);
        using var output = new MemoryStream();
        decompressionStream.CopyTo(output);
        return output.ToArray();
    }
}
