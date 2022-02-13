using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Data.Interfaces;
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
            IEnumerable<LessonReportViewModel> models = await this.reportsService.GetLessonReportsCreatedByMeAsync(this.GetUserId());
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
            model.UserId = this.GetUserId();

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

            LessonReportEditModel model = await this.reportsService.GetByIdAsync<LessonReportEditModel>(reportId);
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

            if (model.UserId != this.GetUserId())
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

            LessonReportDeleteModel model = await this.reportsService.GetByIdAsync<LessonReportDeleteModel>(reportId);
            return this.View(model);
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

            if (model.UserId != this.GetUserId())
            {
                return this.View("Unauthorized");
            }

            await this.reportsService.SoftDeleteReportByIdAsync(model.ReportId);
            return this.RedirectToAction(nameof(this.LessonsByMe));
        }

        [Authorize]
        public async Task<IActionResult> CommentsByMe()
        {
            IEnumerable<CommentReportViewModel> models = await this.reportsService.GetCommentReportsCreatedByMeAsync(this.GetUserId());
            return this.View(models);
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
            return this.View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Comment(CommentReportInputModel model)
        {
            model.UserId = this.GetUserId();

            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.reportsService.CreateCommentReportAsync(model);
            return this.RedirectToAction(nameof(this.CommentsByMe));
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

            CommentReportEditModel model = await this.reportsService.GetByIdAsync<CommentReportEditModel>(reportId);
            return this.View(model);
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

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            if (model.UserId != this.GetUserId())
            {
                return this.View("Unauthorized");
            }

            await this.reportsService.EditCommentReportAsync(model);
            return this.RedirectToAction(nameof(this.CommentsByMe));
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

            CommentReportDeleteModel model = await this.reportsService.GetByIdAsync<CommentReportDeleteModel>(reportId);
            return this.View(model);
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

            if (model.UserId != this.GetUserId())
            {
                return this.View(nameof(this.Unauthorized));
            }

            await this.reportsService.SoftDeleteReportByIdAsync(model.ReportId);
            return this.RedirectToAction(nameof(this.CommentsByMe));
        }
    }
}
