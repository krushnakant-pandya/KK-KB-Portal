using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.Posts
{
    [TableName("PostRevision")]
    public class PostRevision
    {
        [KeyColumn]
        public int RevisionId { get; set; }

        public int PostId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int EditedBy { get; set; }
        public DateTime EditedAt { get; set; }
    }
}
}
