namespace Portal.Contracts.News;

/// <summary>Lightweight projection for news list/search results — omits Content to keep list payloads small.</summary>
public sealed class NewsArticleListItemDto
{
    public int NewsArticleId { get; init; }
    public string Title { get; init; } = string.Empty;
    public string Slug { get; init; } = string.Empty;
    public string? Summary { get; init; }
    public string? FeaturedImageUrl { get; init; }
    public int CategoryId { get; init; }
    public bool IsBreakingNews { get; init; }
    public string Status { get; init; } = string.Empty;
    public long ViewCount { get; init; }
    public DateTime? PublishedAt { get; init; }
}
