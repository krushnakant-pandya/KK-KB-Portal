namespace Portal.Contracts.KnowledgeBase;

public sealed class CreateKbSubTopicRequest
{
    public int MainTopicId { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public int DisplayOrder { get; init; }
}
