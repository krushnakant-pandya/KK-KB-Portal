using Portal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Common
{
    public interface IPublishableContent : IHasCreatedAt, IHasUpdatedAt, ISoftDeletable
    {
        string Title { get; set; }
        string Slug { get; set; }
        string? Summary { get; set; }
        string Content { get; set; }
        string? FeaturedImageUrl { get; set; }
        int AuthorId { get; set; }
        int CategoryId { get; set; }
        ContentStatus Status { get; set; }
        bool AllowComments { get; set; }
        long ViewCount { get; set; }
        string? MetaTitle { get; set; }
        string? MetaDescription { get; set; }
        DateTime? PublishedAt { get; set; }
    }
}
