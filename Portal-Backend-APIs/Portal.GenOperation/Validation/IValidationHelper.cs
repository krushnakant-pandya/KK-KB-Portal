namespace Portal.GenOperation.Validation;

/// <summary>Ad-hoc format checks reused by FluentValidation validators and non-HTTP callers alike (e.g. NewsletterService). The request-pipeline validation itself is FluentValidation, wired in the API layer.</summary>
public interface IValidationHelper
{
    bool IsValidEmail(string value);

    bool IsValidUrl(string value);

    bool IsValidSlug(string value);
}
