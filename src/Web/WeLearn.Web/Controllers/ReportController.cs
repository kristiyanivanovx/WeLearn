using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Interfaces;
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
            IEnumerable<LessonReportViewModel> models = await this.reportsService.GetLessonReportsCreatedByMeAsync(GetUserId());
            return this.View(models);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Lesson(int id)
        {
            if (!this.lessonsService.Contains(id))
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            LessonReportInputModel lessonToReport = await this.lessonsService.GetLessonByIdAsync<LessonReportInputModel>(id);
            return this.View(lessonToReport);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Lesson(LessonReportInputModel model)
        {
            model.ApplicationUserId = this.GetUserId();

            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.reportsService.CreateLessonReportAsync(model);
            return this.RedirectToAction(nameof(this.LessonsByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> LessonEdit(int reportId)
        {
            if (!this.reportsService.Contains(reportId))
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            LessonReportEditModel model = await this.reportsService.GetReportByIdAsync<LessonReportEditModel>(reportId);
            return this.View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LessonEdit(LessonReportEditModel model)
        {
            if (!this.reportsService.Contains(model.ReportId))
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            if (model.ApplicationUserId != this.GetUserId())
            {
                return this.View("Unauthorized");
            }

            await this.reportsService.EditLessonReportAsync(model);
            return this.RedirectToAction(nameof(this.LessonsByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> LessonDelete(int reportId)
        {
            if (!this.reportsService.Contains(reportId))
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            LessonReportDeleteModel model = await this.reportsService.GetReportByIdAsync<LessonReportDeleteModel>(reportId);
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LessonDelete(LessonReportDeleteModel model)
        {
            if (!this.reportsService.Contains(model.ReportId))
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            if (model.ApplicationUserId != GetUserId())
            {
                return View("Unauthorized");
            }

            await this.reportsService.SoftDeleteReportByIdAsync(model.ReportId);
            return RedirectToAction(nameof(LessonsByMe));
        }

        [Authorize]
        public async Task<IActionResult> CommentsByMe()
        {
            IEnumerable<CommentReportViewModel> models = await this.reportsService.GetCommentReportsCreatedByMeAsync(GetUserId());
            return View(models);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Comment(int id)
        {
            if (!this.commentsService.Contains(id))
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            CommentReportInputModel model = await this.commentsService.GetCommentByIdWithDeletedAsync<CommentReportInputModel>(id);
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Comment(CommentReportInputModel model)
        {
            model.ApplicationUserId = GetUserId();

            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.reportsService.CreateCommentReportAsync(model);
            return RedirectToAction(nameof(CommentsByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CommentEdit(int reportId)
        {
            if (!this.reportsService.Contains(reportId))
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            CommentReportEditModel model = await this.reportsService.GetReportByIdAsync<CommentReportEditModel>(reportId);
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CommentEdit(CommentReportEditModel model)
        {
            if (!this.reportsService.Contains(model.ReportId))
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.ApplicationUserId != GetUserId())
            {
                return View("Unauthorized");
            }

            await this.reportsService.EditCommentReportAsync(model);
            return RedirectToAction(nameof(CommentsByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CommentDelete(int reportId)
        {
            if (!this.reportsService.Contains(reportId))
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            CommentReportDeleteModel model = await this.reportsService.GetReportByIdAsync<CommentReportDeleteModel>(reportId);
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CommentDelete(CommentReportDeleteModel model)
        {
            if (!this.reportsService.Contains(model.ReportId))
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            if (model.ApplicationUserId != GetUserId())
            {
                return View(nameof(Unauthorized));
            }

            await this.reportsService.SoftDeleteReportByIdAsync(model.ReportId);
            return RedirectToAction(nameof(CommentsByMe));
        }
    }
}
