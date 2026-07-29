namespace Portal.Contracts.KnowledgeBase;

public sealed class KbPageDto
{
    public int KbPageId { get; init; }
    public int KbTagId { get; init; }
    public string Title { get; init; } = string.Empty;
    public string Slug { get; init; } = string.Empty;
    public string? Summary { get; init; }
    public string Content { get; init; } = string.Empty;
    public int AuthorId { get; init; }
    public string Status { get; init; } = string.Empty;
    public long ViewCount { get; init; }
    public int HelpfulYesCount { get; init; }
    public int HelpfulNoCount { get; init; }
    public string? MetaTitle { get; init; }
    public string? MetaDescription { get; init; }
    public DateTime? PublishedAt { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime? UpdatedAt { get; init; }
}
