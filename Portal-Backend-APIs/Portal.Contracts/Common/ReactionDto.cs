namespace Portal.Contracts.Common;

/// <summary>Shared response shape for NewsReactions and PostReactions.</summary>
public sealed class ReactionDto
{
    public int ReactionId { get; init; }
    public int UserId { get; init; }
    public string ReactionType { get; init; } = string.Empty;
    public DateTime CreatedAt { get; init; }
}
