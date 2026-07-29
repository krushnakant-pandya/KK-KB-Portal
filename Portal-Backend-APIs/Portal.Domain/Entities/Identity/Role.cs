using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.Identity
{
    [TableName("Roles")]
    public class Role
    {
        [KeyColumn]
        public int RoleId { get; set; }

        public string RoleName { get; set; } = string.Empty;

        public string? Description { get; set; }
    }
}
