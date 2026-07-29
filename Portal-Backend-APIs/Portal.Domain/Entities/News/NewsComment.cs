using Portal.Domain.Common;
using Portal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.News
{
    [TableName("NewsComments")]
    internal class NewsComment : IThreadedComment
    {
        [KeyColumn]
        public int CommentId { get; set; }

        public int NewsArticleId { get; set; }
        public int? UserId { get; set; }
        public int? ParentCommentId { get; set; }
        public string? AuthorName { get; set; }
        public string? AuthorEmail { get; set; }
        public string Content { get; set; } = string.Empty;
        public CommentStatus Status { get; set; } = CommentStatus.Pending;
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
