using Portal.GenOperation.Options;
using Portal.GenOperation.Resilience;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;

namespace Portal.GenOperation.Email;

/// <summary>
/// SMTP email via MailKit, with retry for transient network faults. <see cref="SendAsync"/> is the
/// single seam every caller (and every future background worker) goes through, so swapping direct-send
/// for enqueue-to-a-queue later is a one-method change with no caller updates required.
/// </summary>
public sealed class EmailService(IOptions<SmtpOptions> options, IRetryHelper retryHelper, ILogger<EmailService> logger) : IEmailService
{
    private readonly SmtpOptions _settings = options.Value;

    public async Task SendAsync(EmailMessage message, CancellationToken cancellationToken = default)
    {
        var mimeMessage = BuildMimeMessage(message);

        await retryHelper.ExecuteAsync(
            async ct =>
            {
                using var client = new SmtpClient();
                await client.ConnectAsync(_settings.Host, _settings.Port, _settings.UseSsl ? SecureSocketOptions.StartTls : SecureSocketOptions.None, ct);

                if (!string.IsNullOrWhiteSpace(_settings.Username))
                {
                    await client.AuthenticateAsync(_settings.Username, _settings.Password, ct);
                }

                await client.SendAsync(mimeMessage, ct);
                await client.DisconnectAsync(true, ct);
            },
            _settings.MaxRetryAttempts,
            cancellationToken);

        logger.LogInformation("Email sent to {RecipientCount} recipients: {Subject}", message.To.Count, message.Subject);
    }

    public async Task SendTemplatedAsync(string templateName, IReadOnlyDictionary<string, string> tokens, IReadOnlyList<string> to, string subject, CancellationToken cancellationToken = default)
    {
        var templatePath = Path.Combine(AppContext.BaseDirectory, "Email", "Templates", $"{templateName}.html");
        var template = await File.ReadAllTextAsync(templatePath, cancellationToken);

        var body = tokens.Aggregate(template, (current, token) => current.Replace($"{{{{{token.Key}}}}}", token.Value));

        await SendAsync(new EmailMessage { To = to, Subject = subject, HtmlBody = body }, cancellationToken);
    }

    private MimeMessage BuildMimeMessage(EmailMessage message)
    {
        var mimeMessage = new MimeMessage();
        mimeMessage.From.Add(new MailboxAddress(_settings.FromName, _settings.FromAddress));
        mimeMessage.To.AddRange(message.To.Select(MailboxAddress.Parse));
        mimeMessage.Cc.AddRange(message.Cc.Select(MailboxAddress.Parse));
        mimeMessage.Bcc.AddRange(message.Bcc.Select(MailboxAddress.Parse));
        mimeMessage.Subject = message.Subject;

        var bodyBuilder = new BodyBuilder { HtmlBody = message.HtmlBody };

        foreach (var attachment in message.Attachments)
        {
            bodyBuilder.Attachments.Add(attachment.FileName, attachment.Content, ContentType.Parse(attachment.ContentType));
        }

        foreach (var (contentId, imageBytes) in message.InlineImages)
        {
            var image = bodyBuilder.LinkedResources.Add(contentId, imageBytes);
            image.ContentId = contentId;
        }

        mimeMessage.Body = bodyBuilder.ToMessageBody();
        return mimeMessage;
    }
}
