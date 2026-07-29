namespace Portal.Contracts.Posts;

public sealed class UpdatePostRequest
{
    public string Title { get; init; } = string.Empty;
    public string? Summary { get; init; }
    public string Content { get; init; } = string.Empty;
    public string? FeaturedImageUrl { get; init; }
    public int CategoryId { get; init; }
    public string Status { get; init; } = string.Empty;
    public bool IsFeatured { get; init; }
    public bool AllowComments { get; init; } = true;
    public string? MetaTitle { get; init; }
    public string? MetaDescription { get; init; }
    public IReadOnlyList<int> TagIds { get; init; } = [];
}
