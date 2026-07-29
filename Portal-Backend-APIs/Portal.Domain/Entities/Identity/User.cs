using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.Identity
{
    [TableName("Users")]
    public class User:IHasCreatedAt, IHasUpdatedAt
    {
        [KeyColumn]
        public int UserId { get; set; }

        public int RoleId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string? PasswordSalt { get; set; }
        public string? FullName { get; set; }
        public string? Bio { get; set; }
        public string? ProfileImageUrl { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsEmailVerified { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }
    }
}
