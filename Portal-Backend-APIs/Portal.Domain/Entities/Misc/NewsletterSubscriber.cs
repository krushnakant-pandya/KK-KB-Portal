using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.Misc
{
    [TableName("NewsletterSubscribers")]
    public class NewsletterSubscriber
    {
        [KeyColumn]
        public int SubscriberId { get; set; }

        public string Email { get; set; } = string.Empty;
        public bool IsConfirmed { get; set; }
        public DateTime SubscribedAt { get; set; }
        public DateTime? UnsubscribedAt { get; set; }
    }
}
