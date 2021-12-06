using System.Security.Claims;

namespace WeLearn.Web.Infrastructure
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal @this) => @this.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    }
}
