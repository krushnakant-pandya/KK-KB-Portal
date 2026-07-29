using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.KnowledgeBase
{
    public class KbPageRelated
    {
        public int KbPageId { get; set; }
        public int RelatedKbPageId { get; set; }
    }
}
