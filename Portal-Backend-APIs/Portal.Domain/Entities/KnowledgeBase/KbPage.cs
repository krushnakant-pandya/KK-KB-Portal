using Portal.Domain.Common;
using Portal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.KnowledgeBase
{
    [TableName("KBPages")]
    public class KbPage : IHasCreatedAt, IHasUpdatedAt, ISoftDeletable
    {
        [KeyColumn]
        public int KbPageId { get; set; }

        public int KbTagId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string? Summary { get; set; }
        public string Content { get; set; } = string.Empty;
        public int AuthorId { get; set; }
        public ContentStatus Status { get; set; } = ContentStatus.Draft;
        public long ViewCount { get; set; }
        public int HelpfulYesCount { get; set; }
        public int HelpfulNoCount { get; set; }
        public string? MetaTitle { get; set; }
        public string? MetaDescription { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
