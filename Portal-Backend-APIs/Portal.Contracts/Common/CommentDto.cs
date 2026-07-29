namespace Portal.Contracts.Common;

/// <summary>Shared response shape for NewsComments and PostComments — identical fields on both tables.</summary>
public sealed class CommentDto
{
    public int CommentId { get; init; }
    public int? UserId { get; init; }
    public int? ParentCommentId { get; init; }
    public string? AuthorName { get; init; }
    public string Content { get; init; } = string.Empty;
    public string Status { get; init; } = string.Empty;
    public DateTime CreatedAt { get; init; }
}
