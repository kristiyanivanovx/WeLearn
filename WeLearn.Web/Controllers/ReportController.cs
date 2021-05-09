using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using WeLearn.ViewModels;
using WeLearn.Services;
using WeLearn.Services.Interfaces;

namespace WeLearn.Web.Controllers
{
    public class ReportController : Controller
    {
        private readonly ILessonsService lessonsService;
        private readonly ICommentsService commentsService;
        private readonly IReportsService reportsService;
        private readonly IHttpContextAccessor httpContextAccessor;

        public ReportController(
            ILessonsService lessonsService,
            ICommentsService commentsService,
            IReportsService reportsService,
            IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.lessonsService = lessonsService;
            this.commentsService = commentsService;
            this.reportsService = reportsService;
        }

        [Authorize]
        public async Task<IActionResult> LessonsByMe()
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var myReports = await reportsService.CreatedByMeToLessonReportVMAsync(userId);
            return View(myReports);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Lesson(int id)
        {
            var lessonToReport = await lessonsService.GetLessonByIdAsync<LessonReportModel>(id);
            return View(lessonToReport);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Lesson(LessonReportModel lessonReportModel)
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            lessonReportModel.ReportingUserId = userId;

            if (!ModelState.IsValid)
            {
                return View();
            }

            await reportsService.CreateReportAsync(lessonReportModel);
            return View("ThankYou");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> LessonEdit(int reportId)
        {
            var lessonToEdit = await reportsService.GetReportById<LessonReportModel>(reportId);
            return View(lessonToEdit);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LessonEdit(LessonReportModel lessonReportModel)
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (!ModelState.IsValid)
            {
                return View(lessonReportModel);
            }

            if (lessonReportModel.ReportingUserId != userId)
            {
                return View("Unauthorized");
            }

            await reportsService.EditLessonReportAsync(lessonReportModel);
            return View("ThankYou");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> LessonDelete(int reportId)
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var lessonReportAsViewModel = await reportsService.GetReportById<LessonReportModel>(reportId);

            if (lessonReportAsViewModel.ReportingUserId != userId)
            {
                return View("Unauthorized");
            }

            return View(lessonReportAsViewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LessonDelete(LessonReportModel lessonReportModel)
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var reportFromDb = await reportsService.GetReportByIdToReportAsync(lessonReportModel.ReportId.GetValueOrDefault());

            if (reportFromDb.ApplicationUserId != userId)
            {
                return View("Unauthorized");
            }

            await reportsService.DeleteReportAsync(reportFromDb);
            return View("Deleted");
        }

        [Authorize]
        public async Task<IActionResult> CommentsByMe()
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var myReports = await reportsService.CreatedByMeToCommentReportVMAsync(userId);
            return View(myReports);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Comment(int id)
        {
            var lessonToReport = await commentsService.GetCommentByIdAsync<CommentReportModel>(id);
            return View(lessonToReport);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Comment(CommentReportModel commentReportModel)
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            commentReportModel.ReportingUserId = userId;

            if (!ModelState.IsValid)
            {
                return View();
            }

            await reportsService.CreateReportAsync(commentReportModel);
            return View("ThankYou");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CommentEdit(int reportId)
        {
            var editCommentReport = await reportsService.GetReportById<CommentReportModel>(reportId);
            return View(editCommentReport);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CommentEdit(CommentReportModel commentReportModel)
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (!ModelState.IsValid)
            {
                return View(commentReportModel);
            }

            if (commentReportModel.ReportingUserId != userId)
            {
                return View("Unauthorized");
            }

            await reportsService.EditCommentReportAsync(commentReportModel);
            return View("ThankYou");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CommentDelete(int reportId)
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var lessonReportViewModel = await reportsService.GetReportById<CommentReportModel>(reportId);

            if (lessonReportViewModel.ReportingUserId != userId)
            {
                return View("Unauthorized");
            }

            return View(lessonReportViewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CommentDelete(CommentReportModel commentReportModel)
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var reportFromDb = await reportsService.GetReportByIdToReportAsync(commentReportModel.ReportId.GetValueOrDefault());

            if (reportFromDb.ApplicationUserId != userId)
            {
                return View("Unauthorized");
            }

            await reportsService.DeleteReportAsync(reportFromDb);
            return View("Deleted");
        }
    }
}
