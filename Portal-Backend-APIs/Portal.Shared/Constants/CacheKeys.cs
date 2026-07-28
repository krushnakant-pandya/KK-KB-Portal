using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Shared.Constants
{
    public static class CacheKeys
    {
        public static string ById(string entityName, object id) => $"{entityName}:id:{id}";

        public static string BySlug(string entityName, string slug) => $"{entityName}:slug:{slug}";

        public static string Page(string entityName, int pageNumber, int pageSize, string? queryHash = null) =>
            queryHash is null
                ? $"{entityName}:page:{pageNumber}:{pageSize}"
                : $"{entityName}:page:{pageNumber}:{pageSize}:{queryHash}";

        /// <summary>Prefix used to bulk-invalidate every cache entry for an entity on write (e.g. all pages after a Create).</summary>
        public static string Prefix(string entityName) => $"{entityName}:";
    }
}
