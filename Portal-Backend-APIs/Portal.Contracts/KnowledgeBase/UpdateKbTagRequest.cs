namespace Portal.Contracts.KnowledgeBase;

public sealed class UpdateKbTagRequest
{
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public int DisplayOrder { get; init; }
    public bool IsActive { get; init; }
}
