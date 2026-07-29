using Portal.Shared.Wrappers;

namespace Portal.Contracts.Common;

/// <summary>Shared query shape for the News and Posts list endpoints — both are IPublishableContent-backed and filter the same way.</summary>
public class ContentQueryParameters : PagedRequest
{
    public int? CategoryId { get; set; }
    public string? Status { get; set; }
    public string? Tag { get; set; }
}
