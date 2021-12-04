using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WeLearn.Services;
using WeLearn.Services.Interfaces;
using System.Collections.Generic;
using WeLearn.Web.ViewModels.Report.Comment;
using WeLearn.Web.ViewModels.Report.Lesson;

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
            lessonReportModel.ApplicationUserId = this.GetUserId();

            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.reportsService.CreateLessonReportAsync(lessonReportModel);
            return this.RedirectToAction(nameof(this.LessonsByMe));
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
            CommentReportInputModel lessonToReport = await this.commentsService.GetCommentByIdWithDeletedAsync<CommentReportInputModel>(id);
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

            await this.reportsService.CreateCommentReportAsync(commentReportModel);
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
