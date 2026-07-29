using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.Misc
{
    [TableName("Settings")]
    public class Setting
    {
        [KeyColumn]
        public string SettingKey { get; set; } = string.Empty;

        public string? SettingValue { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
