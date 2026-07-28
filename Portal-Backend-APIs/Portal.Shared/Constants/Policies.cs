using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Shared.Constants
{
    public static class Policies
    {
        /// <summary>Admin, Editor — manage the KB hierarchy and any KB page.</summary>
        public const string CanManageKb = nameof(CanManageKb);

        /// <summary>Admin, Editor, Reporter — create/edit news articles.</summary>
        public const string CanPublishNews = nameof(CanPublishNews);

        /// <summary>Admin, Editor, Author — create/edit blog posts.</summary>
        public const string CanPublishPosts = nameof(CanPublishPosts);

        /// <summary>Admin, Editor — approve/reject/spam-mark comments on news articles and posts.</summary>
        public const string CanModerateComments = nameof(CanModerateComments);

        /// <summary>Admin only — manage users, roles, categories, tags, media, and site settings.</summary>
        public const string CanManageSite = nameof(CanManageSite);
    }
}
