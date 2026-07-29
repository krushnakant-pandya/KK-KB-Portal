namespace Portal.GenOperation.Email;

public interface IEmailService
{
    Task SendAsync(EmailMessage message, CancellationToken cancellationToken = default);

    /// <summary>Loads a template file, replaces {{Token}} placeholders, and sends. Templates live under GenOperation/Email/Templates.</summary>
    Task SendTemplatedAsync(string templateName, IReadOnlyDictionary<string, string> tokens, IReadOnlyList<string> to, string subject, CancellationToken cancellationToken = default);
}
