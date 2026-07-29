namespace Portal.Contracts.Common;

/// <summary>Shared request shape for reacting to a NewsArticle or Post; calling again with the same user toggles/replaces the reaction (DB enforces one row per parent+user).</summary>
public sealed class CreateReactionRequest
{
    public string ReactionType { get; init; } = string.Empty;
}
