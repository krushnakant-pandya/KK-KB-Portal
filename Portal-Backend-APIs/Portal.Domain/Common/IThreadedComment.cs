using Portal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Common
{
    public interface IThreadedComment : IHasCreatedAt, ISoftDeletable
    {
        int CommentId { get; set; }

        int? UserId { get; set; }
        int? ParentCommentId { get; set; }
        string? AuthorName { get; set; }
        string? AuthorEmail { get; set; }
        string Content { get; set; }
        CommentStatus Status { get; set; }
    }
}
