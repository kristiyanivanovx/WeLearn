using System.Security.Claims;

using Microsoft.AspNetCore.Mvc;

namespace WeLearn.Web.Controllers
{
    public class BaseController : Controller
    {
        protected string GetUserId() => User.FindFirst(ClaimTypes.NameIdentifier).Value;

        protected string GetUserName() => User.Identity.Name;
    }
}
