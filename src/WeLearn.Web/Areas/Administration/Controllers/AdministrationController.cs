using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static WeLearn.Common.Constants;

namespace WeLearn.Web.Areas.Administration.Controllers
{
	[Area(ApplicationAdministrationAreaName)]
	[Authorize(Roles = ApplicationAdministratorRoleName)]
	public class AdministrationController : Controller
	{
	}
}
