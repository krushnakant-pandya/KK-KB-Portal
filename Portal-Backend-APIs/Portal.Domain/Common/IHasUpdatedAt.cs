using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Common
{
    public interface IHasUpdatedAt
    {
        DateTime? UpdatedAt { get; set; }
    }
}
