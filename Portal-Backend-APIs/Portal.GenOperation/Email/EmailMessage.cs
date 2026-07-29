namespace Portal.GenOperation.Email;

public sealed class EmailMessage
{
    public required IReadOnlyList<string> To { get; init; }
    public IReadOnlyList<string> Cc { get; init; } = [];
    public IReadOnlyList<string> Bcc { get; init; } = [];
    public required string Subject { get; init; }
    public required string HtmlBody { get; init; }
    public IReadOnlyList<EmailAttachment> Attachments { get; init; } = [];

    /// <summary>Content-ID -> image bytes, referenced in HtmlBody via &lt;img src="cid:{key}"&gt;.</summary>
    public IReadOnlyDictionary<string, byte[]> InlineImages { get; init; } = new Dictionary<string, byte[]>();
}
