namespace Portal.GenOperation.DateTimeUtil;

/// <summary>Abstraction over DateTime.UtcNow so time-dependent logic (token expiry, publish scheduling) is testable without waiting on the real clock.</summary>
public interface IDateTimeService
{
    DateTime UtcNow { get; }
}
