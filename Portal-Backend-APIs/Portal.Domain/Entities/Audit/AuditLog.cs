using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.Audit
{
    [TableName("AuditLogs")]
    public class AuditLog
    {
        [KeyColumn]
        public long AuditLogId { get; set; }
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public string? IpAddress { get; set; }
        public string? MachineName { get; set; }
        public string? RequestId { get; set; }
        public string? CorrelationId { get; set; }
        public string? SessionId { get; set; }
        public string? Browser { get; set; }
        public string? Device { get; set; }
        public string? Os { get; set; }
        public string? RequestUrl { get; set; }
        public string? HttpMethod { get; set; }
        public string? Controller { get; set; }
        public string? Action { get; set; }
        public DateTime TimestampUtc { get; set; }
        public string? TimeZone { get; set; }
        public string? GeoLocation { get; set; }
        public string? OldValues { get; set; }
        public string? NewValues { get; set; }
        public string? EntityName { get; set; }
        public string? TableName { get; set; }
        public string? Operation { get; set; }
        public bool Success { get; set; }
        public string? ExceptionMessage { get; set; }
        public long ExecutionTimeMs { get; set; }
        public string? RequestPayload { get; set; }
        public string? ResponsePayload { get; set; }
    }
}
