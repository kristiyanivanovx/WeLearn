using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WeLearn.Web.Controllers
{
    public class BaseController : Controller
    {
        protected string GetUserId() => User.FindFirst(ClaimTypes.NameIdentifier).Value;
    }
}
