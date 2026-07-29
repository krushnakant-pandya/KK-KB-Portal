using System.Text.RegularExpressions;

namespace Portal.GenOperation.Files;

public sealed partial class FileHelper : IFileHelper
{
    private static readonly string[] SizeUnits = ["B", "KB", "MB", "GB", "TB"];

    public string GetSafeFileName(string originalFileName)
    {
        var extension = Path.GetExtension(originalFileName);
        var nameWithoutExtension = Path.GetFileNameWithoutExtension(originalFileName);
        var safeName = UnsafeCharsRegex().Replace(nameWithoutExtension, "-").Trim('-');
        return $"{safeName}-{Guid.NewGuid():N}{extension}";
    }

    public string GetExtension(string fileName) => Path.GetExtension(fileName).TrimStart('.').ToLowerInvariant();

    public bool IsAllowedExtension(string fileName, IReadOnlyCollection<string> allowedExtensions) =>
        allowedExtensions.Contains(GetExtension(fileName), StringComparer.OrdinalIgnoreCase);

    public string FormatFileSize(long sizeInBytes)
    {
        double size = sizeInBytes;
        var unitIndex = 0;

        while (size >= 1024 && unitIndex < SizeUnits.Length - 1)
        {
            size /= 1024;
            unitIndex++;
        }

        return $"{size:0.##} {SizeUnits[unitIndex]}";
    }

    [GeneratedRegex(@"[^a-zA-Z0-9\-_]+")]
    private static partial Regex UnsafeCharsRegex();
}
