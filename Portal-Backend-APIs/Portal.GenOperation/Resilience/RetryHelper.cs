using Microsoft.Extensions.Logging;
using Polly;
using Polly.Retry;

namespace Portal.GenOperation.Resilience;

public sealed class RetryHelper(ILogger<RetryHelper> logger) : IRetryHelper
{
    public async Task<T> ExecuteAsync<T>(Func<CancellationToken, Task<T>> operation, int maxAttempts = 3, CancellationToken cancellationToken = default)
    {
        var pipeline = BuildPipeline(maxAttempts);
        return await pipeline.ExecuteAsync(async ct => await operation(ct), cancellationToken);
    }

    public async Task ExecuteAsync(Func<CancellationToken, Task> operation, int maxAttempts = 3, CancellationToken cancellationToken = default)
    {
        var pipeline = BuildPipeline(maxAttempts);
        await pipeline.ExecuteAsync(async ct => await operation(ct), cancellationToken);
    }

    private ResiliencePipeline BuildPipeline(int maxAttempts) =>
        new ResiliencePipelineBuilder()
            .AddRetry(new RetryStrategyOptions
            {
                MaxRetryAttempts = maxAttempts,
                BackoffType = DelayBackoffType.Exponential,
                Delay = TimeSpan.FromMilliseconds(200),
                OnRetry = args =>
                {
                    logger.LogWarning(args.Outcome.Exception, "Retry attempt {Attempt} after failure", args.AttemptNumber + 1);
                    return ValueTask.CompletedTask;
                },
            })
            .Build();
}
