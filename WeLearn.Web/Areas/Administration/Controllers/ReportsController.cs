using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Services;
using WeLearn.ViewModels;
using System.Collections.Generic;
using WeLearn.ViewModels.HelperModels;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Authorize(Roles = "Admin")]
    public class ReportsController : Controller
    {
        private readonly IReportsService reportsService;

        public ReportsController(IReportsService reportsService)
            => this.reportsService = reportsService;

        [HttpGet]
        public async Task<IActionResult> Index(string searchString, int? pageNumber)
        {
            ViewData["SearchString"] = searchString;
            IEnumerable<AdministrationReportModel> reports = await reportsService.GetAllReportsAsync(searchString);
            var paginated = PaginatedList<AdministrationReportModel>.Create(reports.OrderBy(x => x.Id), pageNumber ?? 1, 6);
            return View(paginated);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            IEnumerable<AdministrationReportModel> reports = await reportsService.GetAllReportsAsync();
            AdministrationReportModel report = reports.FirstOrDefault(x => x.Id == id);
            return View(report);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AdministrationReportModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await reportsService.EditReportAdministrationAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            IEnumerable<AdministrationReportModel> reports = await reportsService.GetAllReportsAsync();
            AdministrationReportModel report = reports.FirstOrDefault(x => x.Id == id);
            return View(report);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await reportsService.HardDeleteReportByIdAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
