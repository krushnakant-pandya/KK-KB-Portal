namespace Portal.Contracts.Common;

/// <summary>Shared request shape for posting a comment to a NewsArticle or Post; the parent id comes from the route, not the body.</summary>
public sealed class CreateCommentRequest
{
    public int? ParentCommentId { get; init; }

    /// <summary>Required only for guest (unauthenticated) comments — ignored when the caller is authenticated.</summary>
    public string? AuthorName { get; init; }

    public string? AuthorEmail { get; init; }
    public string Content { get; init; } = string.Empty;
}
