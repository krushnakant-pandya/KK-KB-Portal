using Portal.Domain.Common;
using Portal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.Posts
{
    [TableName("PostReactions")]
    internal class PostReaction : IReaction
    {
        [KeyColumn]
        public int ReactionId { get; set; }

        public int PostId { get; set; }
        public int UserId { get; set; }
        public ReactionType ReactionType { get; set; } = ReactionType.Like;
        public DateTime CreatedAt { get; set; }
    }
}
