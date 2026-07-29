using Portal.Domain.Common;
using Portal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.News
{
    [TableName("NewsArticles")]
    public class NewsArticle : IPublishableContent
    {
        [KeyColumn]
        public int NewsArticleId { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string? Summary { get; set; }
        public string Content { get; set; } = string.Empty;
        public string? FeaturedImageUrl { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public ArticleType ArticleType { get; set; } = ArticleType.News;
        public ArticlePriority Priority { get; set; } = ArticlePriority.Medium;
        public bool IsBreakingNews { get; set; }
        public string? Source { get; set; }
        public string? SourceUrl { get; set; }
        public string? Byline { get; set; }
        public string? Location { get; set; }
        public ContentStatus Status { get; set; } = ContentStatus.Draft;
        public bool AllowComments { get; set; } = true;
        public long ViewCount { get; set; }
        public string? MetaTitle { get; set; }
        public string? MetaDescription { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
