using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Common
{
    public interface IContentView
    {
        int? UserId { get; set; }
        string? IpAddress { get; set; }
        string? UserAgent { get; set; }
        DateTime ViewedAt { get; set; }
    }
}
