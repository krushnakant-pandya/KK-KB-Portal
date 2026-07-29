namespace Portal.Contracts.KnowledgeBase;

/// <summary>Lightweight projection for KB page list/search results — omits Content to keep list payloads small.</summary>
public sealed class KbPageListItemDto
{
    public int KbPageId { get; init; }
    public int KbTagId { get; init; }
    public string Title { get; init; } = string.Empty;
    public string Slug { get; init; } = string.Empty;
    public string? Summary { get; init; }
    public string Status { get; init; } = string.Empty;
    public long ViewCount { get; init; }
    public DateTime? PublishedAt { get; init; }
}
