using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.KnowledgeBase
{
    [TableName("KBSubTopics")]
    public class KbSubTopic : IHasCreatedAt, IHasUpdatedAt
    {
        [KeyColumn]
        public int SubTopicId { get; set; }

        public int MainTopicId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
