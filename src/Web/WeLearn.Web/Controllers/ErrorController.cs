using Microsoft.AspNetCore.Mvc;

namespace WeLearn.Web.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    this.ViewData["ErrorMessage"] = "Sorry, the resource you have requested could not be found.";
                    break;
            }

            return this.View(nameof(this.NotFound));
        }
    }
}
