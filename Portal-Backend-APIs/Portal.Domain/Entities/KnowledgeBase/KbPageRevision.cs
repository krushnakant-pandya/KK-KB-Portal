using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.KnowledgeBase
{
    [TableName("KBPageRevisions")]
    public class KbPageRevision
    {
        [KeyColumn]
        public int RevisionId { get; set; }

        public int KbPageId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int EditedBy { get; set; }
        public DateTime EditedAt { get; set; }
    }
}
