namespace Portal.Contracts.KnowledgeBase;

public sealed class CreateKbMainTopicRequest
{
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public string? IconUrl { get; init; }
    public int DisplayOrder { get; init; }
}
