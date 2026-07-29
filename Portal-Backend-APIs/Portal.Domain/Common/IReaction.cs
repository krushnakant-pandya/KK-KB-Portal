using Portal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Common
{
    public interface IReaction: IHasCreatedAt
    {
        int ReactionId { get; set; }

        int UserId { get; set; }
        ReactionType ReactionType { get; set; }
    }
}
