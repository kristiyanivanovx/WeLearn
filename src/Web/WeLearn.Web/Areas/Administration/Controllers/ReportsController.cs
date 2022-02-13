using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Web.ViewModels.Admin.Report;
using WeLearn.Web.ViewModels.HelperModels;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    [Area(SystemAdministrationAreaName)]
    [Authorize(Roles = SystemRegularAdministratorRoleName + "," + SystemTeacherRoleName)]
    public class ReportsController : Controller
    {
        private readonly IReportsService reportsService;

        public ReportsController(IReportsService reportsService)
            => this.reportsService = reportsService;

        [HttpGet]
        public async Task<IActionResult> Index(string searchString, int? pageNumber)
        {
            IEnumerable<AdminReportViewModel> reports = await this.reportsService.GetAllAsync<AdminReportViewModel>(searchString);
            var paginated = PaginatedList<AdminReportViewModel>.Create(reports.OrderByDescending(x => x.Id), pageNumber ?? 1, 6);
            paginated.SearchString = searchString;

            return this.View(paginated);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            IEnumerable<AdminReportEditModel> reports = await this.reportsService.GetAllAsync<AdminReportEditModel>();
            AdminReportEditModel report = reports.FirstOrDefault(x => x.Id == id);
            return this.View(report);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AdminReportEditModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            await this.reportsService.EditReportAdministrationAsync(model);
            return this.RedirectToAction(nameof(this.Index));
        }

        [Authorize(Roles = SystemRegularAdministratorRoleName)]
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            IEnumerable<AdminReportDeleteModel> reports = await this.reportsService.GetAllAsync<AdminReportDeleteModel>();
            AdminReportDeleteModel report = reports.FirstOrDefault(x => x.Id == id);
            return this.View(report);
        }

        [Authorize(Roles = SystemRegularAdministratorRoleName)]
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.reportsService.HardDeleteReportByIdAsync(id);
            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
