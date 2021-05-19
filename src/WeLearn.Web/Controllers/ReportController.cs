using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using WeLearn.ViewModels;
using WeLearn.Services;
using WeLearn.Services.Interfaces;
using System.Collections.Generic;
using WeLearn.Data.Models;
using WeLearn.Web.Infrastructure;

namespace WeLearn.Web.Controllers
{
    public class ReportController : BaseController
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

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> LessonsByMe()
        {
            IEnumerable<LessonReportModel> myReports = await reportsService.GetLessonReportsCreatedByMeAsync(GetUserId());
            return View(myReports);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Lesson(int id)
        {
            LessonReportModel lessonToReport = await lessonsService.GetLessonByIdAsync<LessonReportModel>(id);
            return View(lessonToReport);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Lesson(LessonReportModel lessonReportModel)
        {
            lessonReportModel.ReportingUserId = GetUserId();

            if (!ModelState.IsValid)
            {
                return View();
            }

            await reportsService.CreateReportAsync(lessonReportModel);
            return RedirectToAction(nameof(LessonsByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> LessonEdit(int reportId)
        {
            LessonReportModel lessonToEdit = await reportsService.GetReportByIdAsync<LessonReportModel>(reportId);
            return View(lessonToEdit);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LessonEdit(LessonReportModel lessonReportModel)
        {
            if (!ModelState.IsValid)
            {
                return View(lessonReportModel);
            }

            if (lessonReportModel.ReportingUserId != GetUserId())
            {
                return View("Unauthorized");
            }

            await reportsService.EditLessonReportAsync(lessonReportModel);
            return RedirectToAction(nameof(LessonsByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> LessonDelete(int reportId)
        {
            LessonReportModel lessonReportModel = await reportsService.GetReportByIdAsync<LessonReportModel>(reportId);
            return View(lessonReportModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LessonDelete(LessonReportModel lessonReportModel)
        {
            if (lessonReportModel.ReportingUserId != GetUserId())
            {
                return View("Unauthorized");
            }

            await reportsService.SoftDeleteReportByIdAsync(lessonReportModel.ReportId);
            return RedirectToAction(nameof(LessonsByMe));
        }

        [Authorize]
        public async Task<IActionResult> CommentsByMe()
        {
            IEnumerable<CommentReportModel> myReports = await reportsService.GetCommentReportsCreatedByMeAsync(GetUserId());
            return View(myReports);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Comment(int id)
        {
            CommentReportModel lessonToReport = await commentsService.GetCommentByIdAsync<CommentReportModel>(id);
            return View(lessonToReport);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Comment(CommentReportModel commentReportModel)
        {
            commentReportModel.ReportingUserId = GetUserId();

            if (!ModelState.IsValid)
            {
                return View();
            }

            await reportsService.CreateReportAsync(commentReportModel);
            return RedirectToAction(nameof(CommentsByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CommentEdit(int reportId)
        {
            CommentReportModel editCommentReport = await reportsService.GetReportByIdAsync<CommentReportModel>(reportId);
            return View(editCommentReport);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CommentEdit(CommentReportModel commentReportModel)
        {
            if (!ModelState.IsValid)
            {
                return View(commentReportModel);
            }

            if (commentReportModel.ReportingUserId != GetUserId())
            {
                return View("Unauthorized");
            }

            await reportsService.EditCommentReportAsync(commentReportModel);
            return RedirectToAction(nameof(CommentsByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CommentDelete(int reportId)
        {
            CommentReportModel commentReportModel = await reportsService.GetReportByIdAsync<CommentReportModel>(reportId);
            return View(commentReportModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CommentDelete(CommentReportModel commentReportModel)
        {
            if (commentReportModel.ReportingUserId != GetUserId())
            {
                return View(nameof(Unauthorized));
            }

            await reportsService.SoftDeleteReportByIdAsync(commentReportModel.ReportId);
            return RedirectToAction(nameof(CommentsByMe));
        }
    }
}
