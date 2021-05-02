using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using System.Threading.Tasks;

using WeLearn.Data.Models;
using WeLearn.Infrastructure.ViewModels;
using WeLearn.Services;
using WeLearn.Services.Interfaces;

namespace WeLearn.Web.Controllers
{
    public class ReportController : Controller
    {
        private readonly IPostsService postsService;
        private readonly IReportsService reportsService;
        private readonly IHttpContextAccessor httpContextAccessor;

        // actions for every kind of report (post, comment, profile)
        public ReportController(
            UserManager<ApplicationUser> userManager,
            IPostsService postsService,
            IReportsService reportsService,
            IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.postsService = postsService;
            this.reportsService = reportsService;
        }

        [Authorize]
        public async Task<IActionResult> PostsByMe()
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var myReports = await reportsService.CreatedByMeAsync<PostReportModel>(userId);
            return View(myReports);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Post(int id)
        {
            var postToReport = await postsService.GetPostByIdAsync<PostReportModel>(id);
            return View(postToReport);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post(PostReportModel postReportModel)
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            postReportModel.ReportingUserId = userId;

            if (!ModelState.IsValid)
            {
                return View();
            }

            await reportsService.CreateReportAsync(postReportModel);
            return View("ThankYou");
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> PostEdit(int reportId)
        {
            var postToReport = await reportsService.GetReportById<PostReportModel>(reportId);
            return View(postToReport);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PostEdit(PostReportModel postReportModel)
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (postReportModel.ReportingUserId != userId)
            {
                return View("Unauthorized");
            }

            await reportsService.EditPostReportAsync(postReportModel);
            return View("ThankYou");
        }

        [Authorize]
        public async Task<IActionResult> PostDelete(PostReportModel postReportModel)
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var postFromDb = await reportsService.GetReportByIdToReportAsync(postReportModel.ReportId.GetValueOrDefault());

            if (postFromDb.ApplicationUserId != userId)
            {
                return View("Unauthorized");
            }

            await reportsService.DeletePostReportAsync(postFromDb);
            return View("ThankYou");
        }

        public IActionResult Comment(int commentId)
        {
            return View();
        }

        public IActionResult Profile(int postId)
        {
            return View();
        }
    }
}
