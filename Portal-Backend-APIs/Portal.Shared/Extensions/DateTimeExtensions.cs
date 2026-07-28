using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Shared.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>All timestamp columns in the schema are DATETIME2 written via SYSUTCDATETIME() — this normalizes any DateTime to UTC before it's sent to SQL Server.</summary>
        public static DateTime ToUtcSafe(this DateTime value) => value.Kind switch
        {
            DateTimeKind.Utc => value,
            DateTimeKind.Local => value.ToUniversalTime(),
            _ => DateTime.SpecifyKind(value, DateTimeKind.Utc),
        };
    }
}
