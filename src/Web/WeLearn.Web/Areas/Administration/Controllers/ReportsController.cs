using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Services;
using System.Collections.Generic;
using WeLearn.ViewModels.HelperModels;
using WeLearn.ViewModels.Admin.Report;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    public class ReportsController : AdministrationController
    {
        private readonly IReportsService reportsService;

        public ReportsController(IReportsService reportsService)
            => this.reportsService = reportsService;

        [HttpGet]
        public async Task<IActionResult> Index(string searchString, int? pageNumber)
        {
            IEnumerable<AdminReportViewModel> reports = await this.reportsService.GetAllReportsAsync<AdminReportViewModel>(searchString);
            var paginated = PaginatedList<AdminReportViewModel>.Create(reports.OrderByDescending(x => x.Id), pageNumber ?? 1, 6);
            paginated.SearchString = searchString;
            return View(paginated);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            IEnumerable<AdminReportEditModel> reports = await this.reportsService.GetAllReportsAsync<AdminReportEditModel>();
            AdminReportEditModel report = reports.FirstOrDefault(x => x.Id == id);
            return View(report);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AdminReportEditModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await this.reportsService.EditReportAdministrationAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            IEnumerable<AdminReportDeleteModel> reports = await this.reportsService.GetAllReportsAsync<AdminReportDeleteModel>();
            AdminReportDeleteModel report = reports.FirstOrDefault(x => x.Id == id);
            return View(report);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.reportsService.HardDeleteReportByIdAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
