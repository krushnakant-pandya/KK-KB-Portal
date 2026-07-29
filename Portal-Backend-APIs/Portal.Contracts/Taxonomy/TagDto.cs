namespace Portal.Contracts.Taxonomy;

public sealed class TagDto
{
    public int TagId { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Slug { get; init; } = string.Empty;
}
