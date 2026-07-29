namespace Portal.Contracts.KnowledgeBase;

public sealed class KbTagDto
{
    public int KbTagId { get; init; }
    public int SubTopicId { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Slug { get; init; } = string.Empty;
    public string? Description { get; init; }
    public int DisplayOrder { get; init; }
    public bool IsActive { get; init; }
}
