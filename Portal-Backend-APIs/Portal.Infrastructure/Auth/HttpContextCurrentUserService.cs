using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Web;

namespace Portal.Infrastructure.Auth
{
    public class HttpContextCurrentUserService (IHttpContextAccessor httpContextAccessor) : ICurrentUserService
    {
        private ClaimsPrincipal? User => httpContextAccessor.HttpContext?.User;

        public int? UserId
        {
            get
            {
                var value = User?.FindFirstValue(ClaimTypes.NameIdentifier);
                return int.TryParse(value, out var userId) ? userId : null;
            }
        }

        public string? UserName => User?.FindFirstValue(ClaimTypes.Name);

        public bool IsAuthenticated => User?.Identity?.IsAuthenticated ?? false;

    }
}
