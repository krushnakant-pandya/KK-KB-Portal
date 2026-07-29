namespace Portal.Contracts.Posts;

/// <summary>Lightweight projection for post list/search results — omits Content to keep list payloads small.</summary>
public sealed class PostListItemDto
{
    public int PostId { get; init; }
    public string Title { get; init; } = string.Empty;
    public string Slug { get; init; } = string.Empty;
    public string? Summary { get; init; }
    public string? FeaturedImageUrl { get; init; }
    public int CategoryId { get; init; }
    public bool IsFeatured { get; init; }
    public string Status { get; init; } = string.Empty;
    public long ViewCount { get; init; }
    public DateTime? PublishedAt { get; init; }
}
