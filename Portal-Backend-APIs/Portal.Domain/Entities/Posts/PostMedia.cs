using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.Posts
{
    public class PostMedia
    {
        public int PostId { get; set; }
        public int MediaId { get; set; }
        public int SortOrder { get; set; }
    }
}
