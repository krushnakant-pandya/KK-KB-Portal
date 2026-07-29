using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.News
{
    [TableName("NewsViews")]
    internal class NewsView : IContentView
    {
        [KeyColumn]
        public long ViewId { get; set; }

        public int NewsArticleId { get; set; }
        public int? UserId { get; set; }
        public string? IpAddress { get; set; }
        public string? UserAgent { get; set; }
        public DateTime ViewedAt { get; set; }
    }
}
