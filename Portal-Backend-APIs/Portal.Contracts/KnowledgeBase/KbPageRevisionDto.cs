namespace Portal.Contracts.KnowledgeBase;

public sealed class KbPageRevisionDto
{
    public int RevisionId { get; init; }
    public string Title { get; init; } = string.Empty;
    public int EditedBy { get; init; }
    public DateTime EditedAt { get; init; }
}
