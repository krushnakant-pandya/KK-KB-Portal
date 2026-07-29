namespace Portal.Contracts.News;

public sealed class CreateNewsArticleRequest
{
    public string Title { get; init; } = string.Empty;
    public string? Summary { get; init; }
    public string Content { get; init; } = string.Empty;
    public string? FeaturedImageUrl { get; init; }
    public int CategoryId { get; init; }
    public string ArticleType { get; init; } = "News";
    public string Priority { get; init; } = "Normal";
    public bool IsBreakingNews { get; init; }
    public string? Source { get; init; }
    public string? SourceUrl { get; init; }
    public string? Byline { get; init; }
    public string? Location { get; init; }
    public bool AllowComments { get; init; } = true;
    public string? MetaTitle { get; init; }
    public string? MetaDescription { get; init; }
    public DateTime? ExpiresAt { get; init; }
    public IReadOnlyList<int> TagIds { get; init; } = [];
}
