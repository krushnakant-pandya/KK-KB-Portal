namespace Portal.Contracts.KnowledgeBase;

public sealed class CreateKbPageRequest
{
    public int KbTagId { get; init; }
    public string Title { get; init; } = string.Empty;
    public string? Summary { get; init; }
    public string Content { get; init; } = string.Empty;
    public string? MetaTitle { get; init; }
    public string? MetaDescription { get; init; }
}
