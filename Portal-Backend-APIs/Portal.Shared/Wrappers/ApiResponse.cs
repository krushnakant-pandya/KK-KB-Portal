using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Shared.Wrappers
{
    public class ApiResponse<T>
    {
        public bool Success { get; init; }
        public string Message { get; init; } = string.Empty;
        public List<string> Errors { get; init; } = [];
        public T? Data { get; init; }
        public string TraceId { get; init; } = string.Empty;
        public DateTimeOffset Timestamp { get; init; } = DateTimeOffset.UtcNow;

        public static ApiResponse<T> SuccessResult(T data, string message = "", string traceId = "") => new()
        {
            Success = true,
            Message = message,
            Data = data,
            TraceId = traceId,
        };

        public static ApiResponse<T> FailureResult(string message, IEnumerable<string>? errors = null, string traceId = "") => new()
        {
            Success = false,
            Message = message,
            Errors = errors?.ToList() ?? [],
            TraceId = traceId,
        };
    }
}
