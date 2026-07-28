using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Portal.Shared.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>Converts a title into a URL-safe slug (lowercase, hyphen-separated, diacritics stripped) — every content table's Slug column is populated this way.</summary>
        public static string ToSlug(this string value)
        {
            var normalized = value.Normalize(NormalizationForm.FormD);
            var builder = new StringBuilder(normalized.Length);

            foreach (var c in normalized)
            {
                if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    builder.Append(c);
                }
            }

            var slug = builder.ToString().Normalize(NormalizationForm.FormC).ToLowerInvariant();
            slug = NonAlphaNumericRegex().Replace(slug, "-");
            slug = MultipleHyphensRegex().Replace(slug, "-");
            return slug.Trim('-');
        }

        public static bool IsNullOrWhiteSpace(this string? value) => string.IsNullOrWhiteSpace(value);

        [GeneratedRegex(@"[^a-z0-9]+")]
        private static partial Regex NonAlphaNumericRegex();

        [GeneratedRegex(@"-+")]
        private static partial Regex MultipleHyphensRegex();
    }
}
