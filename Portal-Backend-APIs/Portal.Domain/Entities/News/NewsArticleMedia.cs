using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.News
{
    public class NewsArticleMedia
    {
        public int NewsArticleId { get; set; }
        public int MediaId { get; set; }
        public int SortOrder { get; set; }
    }
}
