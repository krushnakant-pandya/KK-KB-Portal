using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.News
{
    public class NewsArticleTag
    {
        public int NewsArticleId { get; set; }
        public int TagId { get; set; }
    }
}
