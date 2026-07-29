namespace Portal.Contracts.Taxonomy;

/// <summary>URL-based media registration — this build manages file metadata only, not binary upload (see README extension points).</summary>
public sealed class CreateMediaRequest
{
    public string FileName { get; init; } = string.Empty;
    public string FileUrl { get; init; } = string.Empty;
    public string FileType { get; init; } = string.Empty;
    public int? FileSizeKB { get; init; }
    public string? AltText { get; init; }
}
