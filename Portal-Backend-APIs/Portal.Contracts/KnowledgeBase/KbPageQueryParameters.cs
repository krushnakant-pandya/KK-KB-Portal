using Portal.Shared.Wrappers;

namespace Portal.Contracts.KnowledgeBase;

public sealed class KbPageQueryParameters : PagedRequest
{
    public int? KbTagId { get; set; }
    public string? Status { get; set; }
}
