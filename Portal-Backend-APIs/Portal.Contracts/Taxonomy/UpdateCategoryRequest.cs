namespace Portal.Contracts.Taxonomy;

public sealed class UpdateCategoryRequest
{
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public int? ParentCategoryId { get; init; }
    public int DisplayOrder { get; init; }
    public bool IsActive { get; init; }
}
