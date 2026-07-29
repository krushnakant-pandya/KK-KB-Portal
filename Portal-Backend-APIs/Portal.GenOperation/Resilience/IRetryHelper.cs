namespace Portal.GenOperation.Resilience;

/// <summary>Polly-backed retry with exponential backoff, for transient faults (SQL timeouts, SMTP hiccups) — used by EmailService and available to DBOperation for transient SQL faults.</summary>
public interface IRetryHelper
{
    Task<T> ExecuteAsync<T>(Func<CancellationToken, Task<T>> operation, int maxAttempts = 3, CancellationToken cancellationToken = default);

    Task ExecuteAsync(Func<CancellationToken, Task> operation, int maxAttempts = 3, CancellationToken cancellationToken = default);
}
