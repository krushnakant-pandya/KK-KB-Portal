namespace Portal.GenOperation.Files;

/// <summary>File-metadata utilities used by the Media module — this build manages file metadata only, no binary storage (see README extension points).</summary>
public interface IFileHelper
{
    string GetSafeFileName(string originalFileName);

    string GetExtension(string fileName);

    bool IsAllowedExtension(string fileName, IReadOnlyCollection<string> allowedExtensions);

    string FormatFileSize(long sizeInBytes);
}
