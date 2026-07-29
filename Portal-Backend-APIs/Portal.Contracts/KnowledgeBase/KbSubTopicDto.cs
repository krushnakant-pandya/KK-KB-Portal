namespace Portal.Contracts.KnowledgeBase;

public sealed class KbSubTopicDto
{
    public int SubTopicId { get; init; }
    public int MainTopicId { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Slug { get; init; } = string.Empty;
    public string? Description { get; init; }
    public int DisplayOrder { get; init; }
    public bool IsActive { get; init; }
}
