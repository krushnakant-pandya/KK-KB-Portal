using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.Posts
{
    [TableName("PostViews")]
    public class PostView : IContentView
    {
        [KeyColumn]
        public long ViewId { get; set; }

        public int PostId { get; set; }
        public int? UserId { get; set; }
        public string? IpAddress { get; set; }
        public string? UserAgent { get; set; }
        public DateTime ViewedAt { get; set; }
    }
}
