namespace Portal.Contracts.Taxonomy;

public sealed class MediaDto
{
    public int MediaId { get; init; }
    public string FileName { get; init; } = string.Empty;
    public string FileUrl { get; init; } = string.Empty;
    public string FileType { get; init; } = string.Empty;
    public int? FileSizeKB { get; init; }
    public string? AltText { get; init; }
    public int UploadedBy { get; init; }
    public DateTime UploadedAt { get; init; }
}
