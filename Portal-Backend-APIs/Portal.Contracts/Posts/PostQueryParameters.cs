using Portal.Contracts.Common;

namespace Portal.Contracts.Posts;

public sealed class PostQueryParameters : ContentQueryParameters
{
    public bool? IsFeatured { get; set; }
}
