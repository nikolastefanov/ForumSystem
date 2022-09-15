

namespace ForumSystem.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;


    using static WebConstants;


    public static class ClaimsPrincipalExtensions
    {

        public static string Id(this ClaimsPrincipal user)
           => user.FindFirst(ClaimTypes.NameIdentifier).Value;

        public static bool IsAdmin(this ClaimsPrincipal user)
            => user.IsInRole(AdministratorRoleName);

    }
}
