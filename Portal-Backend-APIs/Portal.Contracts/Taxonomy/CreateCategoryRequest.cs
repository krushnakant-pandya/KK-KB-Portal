namespace Portal.Contracts.Taxonomy;

public sealed class CreateCategoryRequest
{
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public int? ParentCategoryId { get; init; }
    public int DisplayOrder { get; init; }
}
