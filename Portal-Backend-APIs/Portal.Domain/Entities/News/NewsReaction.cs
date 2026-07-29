using Portal.Domain.Common;
using Portal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.News
{
    [TableName("NewsReactions")]
    internal class NewsReaction : IReaction
    {
        [KeyColumn]
        public int ReactionId { get; set; }

        public int NewsArticleId { get; set; }
        public int UserId { get; set; }
        public ReactionType ReactionType { get; set; } = ReactionType.Like;
        public DateTime CreatedAt { get; set; }
    }
}
