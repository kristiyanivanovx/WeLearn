using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using WeLearn.Data.Models.Enums;
using WeLearn.Data.Models.InputOutput;
using WeLearn.Services.Interfaces;
using WeLearn.Services.Messaging.Interfaces;
using WeLearn.Web.Controllers;
using WeLearn.Web.ViewModels.HelperModels;
using WeLearn.Web.ViewModels.Lesson;
using WeLearn.Web.ViewModels.Like;

using static WeLearn.Common.GlobalConstants;
using static WeLearn.Data.Common.Validation.DataValidation.Material;
using static WeLearn.Data.Common.Validation.DataValidation.Video;

// todo: change namespace
namespace WeLearn.Controllers
{
    public class LessonController : BaseController
    {
        private readonly int defaultPageNumber = 1;
        private readonly int defaultPageSize = 6;

        private readonly ILikesService likesService;
        private readonly ICategoriesService categoriesService;
        private readonly ILessonsService lessonsService;
        private readonly IEmailSender emailSender;
        private readonly IFileDownloadService fileDownloadService;
        private readonly IWebHostEnvironment environment;

        public LessonController(
            ILikesService likesService,
            ICategoriesService categoriesService,
            ILessonsService lessonsService,
            IEmailSender emailSender,
            IFileDownloadService fileDownloadService,
            IWebHostEnvironment environment)
        {
            this.likesService = likesService;
            this.categoriesService = categoriesService;
            this.lessonsService = lessonsService;
            this.emailSender = emailSender;
            this.fileDownloadService = fileDownloadService;
            this.environment = environment;
        }

        [HttpGet]
        public IActionResult EmailSent() => this.View();

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> LikedByMe()
        {
            // todo: finish up here, render liked by me
            var userId = this.GetUserId();
            var models = await this.likesService.GetByUserId<LikeViewModel>(userId);

            return this.View(models);
        }

        [HttpGet]
        public IActionResult Index() => this.RedirectToAction(nameof(this.All));

        [HttpGet]
        public async Task<IActionResult> All(string searchString, int? pageNumber)
        {
            var models = await this.lessonsService.GetAllLessonsAsync<LessonViewModel>(searchString);
            var paginated = PaginatedList<LessonViewModel>.Create(
                models.OrderByDescending(x => x.LessonId),
                pageNumber ?? this.defaultPageNumber,
                this.defaultPageSize);

            paginated.SearchString = searchString;
            return this.View(paginated);
        }

        [HttpGet]
        public async Task<IActionResult> Watch(int id)
        {
            LessonViewModel model = await this.lessonsService.GetLessonByIdAsync<LessonViewModel>(id);
            if (model == null)
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            return this.View(model);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            var categories = this.categoriesService.GetAllCategories();
            var viewModel = new LessonInputModel
            {
                Categories = categories,
            };

            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize]
        [RequestSizeLimit(MaximumVideoSizeInBytes + MaximumZipFileSizeInBytes)]
        public async Task<IActionResult> Create(LessonInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            await this.lessonsService.CreateLessonAsync(
                model,
                this.environment.WebRootPath,
                this.environment.IsDevelopment(),
                this.GetUserId());

            return this.RedirectToAction(nameof(this.ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            if (!this.lessonsService.Contains(id))
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            LessonEditModel model = await this.lessonsService.GetLessonByIdAsync<LessonEditModel>(id);
            model.Categories = this.categoriesService.GetAllCategories();

            return this.View(model);
        }

        [HttpPost]
        [Authorize]
        [RequestSizeLimit(MaximumVideoSizeInBytes + MaximumZipFileSizeInBytes)]
        public async Task<IActionResult> Edit(LessonEditModel model)
        {
            if (!this.lessonsService.Contains(model.LessonId))
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
                return this.View(nameof(this.Unauthorized));
            }

            await this.lessonsService.EditLessonAsync(
                model,
                this.environment.WebRootPath,
                this.environment.IsDevelopment(),
                this.GetUserId());

            return this.RedirectToAction(nameof(this.ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            if (!this.lessonsService.Contains(id))
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            LessonDeleteModel model = await this.lessonsService.GetLessonByIdAsync<LessonDeleteModel>(id);
            return this.View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(LessonDeleteModel model)
        {
            if (!this.lessonsService.Contains(model.LessonId))
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            if (model.ApplicationUserUserName != this.GetUserName())
            {
                return this.View("Unauthorized");
            }

            await this.lessonsService.SoftDeleteLessonByIdAsync(model.LessonId);
            return this.RedirectToAction(nameof(this.ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ByMe(string searchString, int? pageNumber)
        {
            IEnumerable<LessonViewModel> models =
                await this.lessonsService.GetCreatedByMeAsync(this.GetUserId(), searchString);

            var paginated = PaginatedList<LessonViewModel>.Create(
                models.OrderByDescending(x => x.LessonId),
                pageNumber ?? this.defaultPageNumber,
                this.defaultPageSize);

            paginated.SearchString = searchString;

            return View(paginated);
        }

        [HttpGet]
        public async Task<IActionResult> ByCategory(
            string categoryName,
            string searchString,
            int grade,
            int? pageNumber)
        {
            var lessons =
                await this.lessonsService.GetLessonsByCategoryAndGradeAsync(categoryName, searchString, grade);

            var paginated = PaginatedList<LessonViewModel>.Create(
                lessons.OrderByDescending(x => x.LessonId),
                pageNumber ?? this.defaultPageNumber,
                this.defaultPageSize);

            paginated.Grade = Enum.Parse<Grade>(grade.ToString());
            paginated.CategoryName = categoryName;
            paginated.SearchString = searchString;
            return View(paginated);
        }

        [HttpGet]
        public IActionResult Download([FromQuery] string link)
        {
            FileDownload fileParsed = this.fileDownloadService.DownloadFile(link);
            return File(fileParsed.Content, fileParsed.ContentType, fileParsed.FileName);
        }

        [HttpGet]
        public async Task<IActionResult> Send(int id)
        {
            if (!this.lessonsService.Contains(id))
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            LessonSendEmailViewModel model = await this.lessonsService.GetLessonByIdAsync<LessonSendEmailViewModel>(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Send(LessonSendEmailViewModel model)
        {
            if (!this.lessonsService.Contains(model.LessonId))
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            StringBuilder stringBuilder = new StringBuilder();
            string subject = $"Lesson #{model.LessonId} - {model.Name}";
            string createdBy = model.ApplicationUserUserName ?? "Deleted User";
            string message = BuildMessage(model, stringBuilder, createdBy);

            await this.emailSender.SendEmailAsync(
                ApplicationAdministratorEmail,
                model.Email,
                subject,
                message,
                true);

            return this.View(nameof(this.EmailSent));
        }

        private static string BuildMessage(
            LessonSendEmailViewModel model,
            StringBuilder stringBuilder,
            string createdBy)
        {
            return stringBuilder
                .AppendLine(@$"
                <div>
                    <video playsinline controls crossorigin=""anonymous"" alt=""{model.VideoName}"" src=""{model.VideoLink}"" >
                        <!-- fallback -->
                        Video: <a href=""{model.VideoLink}"">{model.Name}</a>
                    </video>
                </div>
                <div>
				    <p>Materials (as zip file) - {model.MaterialLink}</p>
                    <p>Created by - {createdBy}</p>
				    <p>Category - {model.CategoryName}</p>
				    <p>Grade - {model.Grade}</p>
				    <p>Date created - {model.CreatedOn.ToLocalTime():d/MM/yyyy, HH:mm}</p>
				    <p>Link - <a href=""https://{ApplicationHostName}/lesson/watch/{model.LessonId}"">{model.Name}</a></p>
                </div>")
                .ToString()
                .Trim();
        }
    }
}
