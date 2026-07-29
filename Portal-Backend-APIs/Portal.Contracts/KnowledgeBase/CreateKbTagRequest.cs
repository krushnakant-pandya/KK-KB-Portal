namespace Portal.Contracts.KnowledgeBase;

public sealed class CreateKbTagRequest
{
    public int SubTopicId { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public int DisplayOrder { get; init; }
}
