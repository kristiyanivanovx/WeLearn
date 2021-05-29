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
using WeLearn.ViewModels.Report;
using WeLearn.ViewModels.Comment;
using WeLearn.ViewModels.Report.Comment;
using WeLearn.ViewModels.Report.Lesson;

namespace WeLearn.Web.Controllers
{
    public class ReportController : BaseController
    {
        private readonly ILessonsService lessonsService;
        private readonly ICommentsService commentsService;
        private readonly IReportsService reportsService;

        public ReportController(
            ILessonsService lessonsService,
            ICommentsService commentsService,
            IReportsService reportsService)
        {
            this.lessonsService = lessonsService;
            this.commentsService = commentsService;
            this.reportsService = reportsService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> LessonsByMe()
        {
            IEnumerable<LessonReportViewModel> myReports = await this.reportsService.GetLessonReportsCreatedByMeAsync(GetUserId());
            return View(myReports);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Lesson(int id)
        {
            LessonReportInputModel lessonToReport = await this.lessonsService.GetLessonByIdAsync<LessonReportInputModel>(id);
            return View(lessonToReport);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Lesson(LessonReportInputModel lessonReportModel)
        {
            lessonReportModel.ApplicationUserId = GetUserId();

            if (!ModelState.IsValid)
            {
                return View();
            }

            await this.reportsService.CreateReportAsync<LessonReportInputModel>(lessonReportModel);
            return RedirectToAction(nameof(LessonsByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> LessonEdit(int reportId)
        {
            LessonReportEditModel lessonToEdit = await this.reportsService.GetReportByIdAsync<LessonReportEditModel>(reportId);
            return View(lessonToEdit);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LessonEdit(LessonReportEditModel lessonReportModel)
        {
            if (!ModelState.IsValid)
            {
                return View(lessonReportModel);
            }

            if (lessonReportModel.ApplicationUserId != GetUserId())
            {
                return View("Unauthorized");
            }

            await this.reportsService.EditLessonReportAsync(lessonReportModel);
            return RedirectToAction(nameof(LessonsByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> LessonDelete(int reportId)
        {
            LessonReportDeleteModel lessonReportModel = await this.reportsService.GetReportByIdAsync<LessonReportDeleteModel>(reportId);
            return View(lessonReportModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LessonDelete(LessonReportDeleteModel lessonReportModel)
        {
            if (lessonReportModel.ApplicationUserId != GetUserId())
            {
                return View("Unauthorized");
            }

            await this.reportsService.SoftDeleteReportByIdAsync(lessonReportModel.ReportId);
            return RedirectToAction(nameof(LessonsByMe));
        }

        [Authorize]
        public async Task<IActionResult> CommentsByMe()
        {
            IEnumerable<CommentReportViewModel> myReports = await this.reportsService.GetCommentReportsCreatedByMeAsync(GetUserId());
            return View(myReports);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Comment(int id)
        {
            CommentReportInputModel lessonToReport = await this.commentsService.GetCommentByIdAsync<CommentReportInputModel>(id);
            return View(lessonToReport);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Comment(CommentReportInputModel commentReportModel)
        {
            commentReportModel.ApplicationUserId = GetUserId();

            if (!ModelState.IsValid)
            {
                return View();
            }

            await this.reportsService.CreateReportAsync<CommentReportInputModel>(commentReportModel);
            return RedirectToAction(nameof(CommentsByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CommentEdit(int reportId)
        {
            CommentReportEditModel editCommentReport = await this.reportsService.GetReportByIdAsync<CommentReportEditModel>(reportId);
            return View(editCommentReport);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CommentEdit(CommentReportEditModel commentReportModel)
        {
            if (!ModelState.IsValid)
            {
                return View(commentReportModel);
            }

            if (commentReportModel.ApplicationUserId != GetUserId())
            {
                return View("Unauthorized");
            }

            await this.reportsService.EditCommentReportAsync(commentReportModel);
            return RedirectToAction(nameof(CommentsByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CommentDelete(int reportId)
        {
            CommentReportDeleteModel commentReportModel = await this.reportsService.GetReportByIdAsync<CommentReportDeleteModel>(reportId);
            return View(commentReportModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CommentDelete(CommentReportDeleteModel commentReportModel)
        {
            if (commentReportModel.ApplicationUserId != GetUserId())
            {
                return View(nameof(Unauthorized));
            }

            await this.reportsService.SoftDeleteReportByIdAsync(commentReportModel.ReportId);
            return RedirectToAction(nameof(CommentsByMe));
        }
    }
}
