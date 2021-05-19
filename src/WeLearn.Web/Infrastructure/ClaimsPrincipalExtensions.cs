using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Claims;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Web.ChatApp;

namespace WeLearn.Web.Infrastructure
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal @this) => @this.FindFirst(ClaimTypes.NameIdentifier).Value;
    }
}
