using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    [Area(ApplicationAdministrationAreaName)]
    [Authorize(Roles = ApplicationRegularAdministratorRoleName)]
    public class AdministrationController : Controller
    {
    }
}
