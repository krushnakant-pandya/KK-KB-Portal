using System.Text.RegularExpressions;

namespace Portal.GenOperation.Validation;

public sealed partial class ValidationHelper : IValidationHelper
{
    public bool IsValidEmail(string value) => !string.IsNullOrWhiteSpace(value) && EmailRegex().IsMatch(value);

    public bool IsValidUrl(string value) =>
        Uri.TryCreate(value, UriKind.Absolute, out var uri) && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);

    public bool IsValidSlug(string value) => !string.IsNullOrWhiteSpace(value) && SlugRegex().IsMatch(value);

    [GeneratedRegex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
    private static partial Regex EmailRegex();

    [GeneratedRegex(@"^[a-z0-9]+(?:-[a-z0-9]+)*$")]
    private static partial Regex SlugRegex();
}
