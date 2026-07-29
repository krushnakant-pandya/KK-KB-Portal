using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.Taxonomy
{
    [TableName("Tags")]
    public class Tag : IHasCreatedAt
    {
        [KeyColumn]
        public int TagId { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
