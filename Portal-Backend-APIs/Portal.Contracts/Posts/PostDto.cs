namespace Portal.Contracts.Posts;

public sealed class PostDto
{
    public int PostId { get; init; }
    public string Title { get; init; } = string.Empty;
    public string Slug { get; init; } = string.Empty;
    public string? Summary { get; init; }
    public string Content { get; init; } = string.Empty;
    public string? FeaturedImageUrl { get; init; }
    public int AuthorId { get; init; }
    public int CategoryId { get; init; }
    public string Status { get; init; } = string.Empty;
    public bool IsFeatured { get; init; }
    public bool AllowComments { get; init; }
    public long ViewCount { get; init; }
    public string? MetaTitle { get; init; }
    public string? MetaDescription { get; init; }
    public DateTime? PublishedAt { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime? UpdatedAt { get; init; }
}
