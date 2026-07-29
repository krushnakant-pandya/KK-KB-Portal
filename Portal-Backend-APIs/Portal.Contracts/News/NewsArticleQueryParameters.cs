using Portal.Contracts.Common;

namespace Portal.Contracts.News;

public sealed class NewsArticleQueryParameters : ContentQueryParameters
{
    public bool? IsBreakingNews { get; set; }
}
