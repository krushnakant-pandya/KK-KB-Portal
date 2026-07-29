using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Common
{
    public interface IHasCreatedAt
    {
        DateTime CreatedAt { get; set; }
    }
}
