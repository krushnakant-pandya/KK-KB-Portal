namespace Portal.Contracts.News;

public sealed class NewsArticleDto
{
    public int NewsArticleId { get; init; }
    public string Title { get; init; } = string.Empty;
    public string Slug { get; init; } = string.Empty;
    public string? Summary { get; init; }
    public string Content { get; init; } = string.Empty;
    public string? FeaturedImageUrl { get; init; }
    public int AuthorId { get; init; }
    public int CategoryId { get; init; }
    public string ArticleType { get; init; } = string.Empty;
    public string Priority { get; init; } = string.Empty;
    public bool IsBreakingNews { get; init; }
    public string? Source { get; init; }
    public string? SourceUrl { get; init; }
    public string? Byline { get; init; }
    public string? Location { get; init; }
    public string Status { get; init; } = string.Empty;
    public bool AllowComments { get; init; }
    public long ViewCount { get; init; }
    public string? MetaTitle { get; init; }
    public string? MetaDescription { get; init; }
    public DateTime? PublishedAt { get; init; }
    public DateTime? ExpiresAt { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime? UpdatedAt { get; init; }
}
