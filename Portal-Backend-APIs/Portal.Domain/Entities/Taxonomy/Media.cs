using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.Taxonomy
{
    [TableName("Media")]
    public class Media
    {
        [KeyColumn]
        public int MediaId { get; set; }

        public string FileName { get; set; } = string.Empty;
        public string FileUrl { get; set; } = string.Empty;
        public string FileType { get; set; } = string.Empty;
        public int? FileSizeKB { get; set; }
        public string? AltText { get; set; }
        public int UploadedBy { get; set; }
        public DateTime UploadedAt { get; set; }
    }
}
