using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using System.Threading.Tasks;
using WeLearn.Data.Models;
using WeLearn.ViewModels;
using WeLearn.Services.Interfaces;
using WeLearn.Services.HelperModels;
using System.Collections.Generic;
using static WeLearn.Data.Infrastructure.DataValidation.Video;
using static WeLearn.Data.Infrastructure.DataValidation.Material;
using static WeLearn.Common.Constants;
using WeLearn.ViewModels.HelperModels;
using System.Linq;
using Microsoft.Extensions.Hosting;
using WeLearn.Web.Controllers;
using WeLearn.Web.Infrastructure;
using WeLearn.ViewModels.Lesson;
using WeLearn.ViewModels.Category;
using WeLearn.Data.Models.Enums;
using System;
using System.Text;

namespace WeLearn.Controllers
{
    public class LessonController : BaseController
    {
        private readonly int DefaultPageNumber = 1;
        private readonly int DefaultPageSize = 6;

        private readonly ICategoriesService categoriesService;
        private readonly ILessonsService lessonsService;
		private readonly IEmailSender emailSender;
		private readonly IFileDownloadService fileDownloadService;
        private readonly IWebHostEnvironment environment;

        public LessonController(
            ICategoriesService categoriesService,
            ILessonsService lessonsService,
            IEmailSender emailSender,
            IFileDownloadService fileDownloadService,
            IWebHostEnvironment environment) 
        {
            this.categoriesService = categoriesService;
            this.lessonsService = lessonsService;
			this.emailSender = emailSender;
			this.fileDownloadService = fileDownloadService;
            this.environment = environment;
        }

        [HttpGet]
        public IActionResult EmailSent() => View();

        [HttpGet]
        public IActionResult Index() => RedirectToAction(nameof(All));

        [HttpGet]
        public async Task<IActionResult> All(string searchString, int? pageNumber)
        {
            var models = await this.lessonsService.GetAllLessonsAsync<LessonViewModel>(searchString);
            var paginated = PaginatedList<LessonViewModel>.Create(models.OrderByDescending(x => x.LessonId), pageNumber ?? DefaultPageNumber, DefaultPageSize);
            paginated.SearchString = searchString;
            return View(paginated);
        }

        [HttpGet]
        public async Task<IActionResult> Watch(int id)
        {
            LessonViewModel model = await this.lessonsService.GetLessonByIdAsync<LessonViewModel>(id);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Send(int id)
        {
            LessonSendEmailViewModel model = await this.lessonsService.GetLessonByIdAsync<LessonSendEmailViewModel>(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Send(LessonSendEmailViewModel model)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string subject = $"Lesson #{model.LessonId} - {model.Name}";

            string createdBy = model.ApplicationUserUserName == null ? "Deleted User" : model.ApplicationUserUserName;

            string message = stringBuilder
                .AppendLine(@$"
                <div>
                    <video playsinline controls crossorigin=""anonymous"" alt=""{model.VideoName}"" >
			            <source src=""{model.VideoLink}"" type=""{ model.VideoContentType}"" />
		            </video>
                </div>
                <div>
                    <p>Created by - {createdBy} | </p>
				    <p>Category - {model.CategoryName} | </p>
				    <p>Grade - {model.Grade} | </p>
				    <p>Date created - {model.DateCreated.ToShortDateString()}</p>
                </div>")
                .ToString()
                .Trim();

            await this.emailSender.SendEmailAsync(ApplicationAdministratorEmail, model.Email, subject, message, true);
            return View(nameof(EmailSent));
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            IEnumerable<CategoryViewModel> categories = this.categoriesService.GetAllCategories();
            ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "Name");
            return View();
        }

        [HttpPost]
        [Authorize]
        [RequestSizeLimit(MaximumVideoSizeInBytes + MaximumZipFileSizeInBytes)]
        public async Task<IActionResult> Create(LessonInputModel model)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<CategoryViewModel> categories = this.categoriesService.GetAllCategories();
                ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "Name", model.CategoryId);
                return View(model);
            }

            await this.lessonsService.CreateLessonAsync(model, this.environment.WebRootPath, this.environment.IsDevelopment(), GetUserId());
            return RedirectToAction(nameof(ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            LessonEditModel model = await this.lessonsService.GetLessonByIdAsync<LessonEditModel>(id);
            IEnumerable<CategoryViewModel> categories = this.categoriesService.GetAllCategories();
            ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "Name", model.CategoryId);
            return View(model);
        }

        [HttpPost]
        [Authorize]
        [RequestSizeLimit(MaximumVideoSizeInBytes + MaximumZipFileSizeInBytes)]
        public async Task<IActionResult> Edit(LessonEditModel model)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<CategoryViewModel> categories = this.categoriesService.GetAllCategories();
                ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName", model.CategoryId);
                return View(model);
            }

            if (model.UserId != GetUserId())
            {
                return View(nameof(Unauthorized));
            }

            await this.lessonsService.EditLessonAsync(model, this.environment.WebRootPath, this.environment.IsDevelopment(), GetUserId());
            return RedirectToAction(nameof(ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            LessonDeleteModel model = await this.lessonsService.GetLessonByIdAsync<LessonDeleteModel>(id);
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(LessonDeleteModel model)
        {
            if (model.ApplicationUserUserName != GetUserName())
            {
                return View("Unauthorized");
            }

            await this.lessonsService.SoftDeleteLessonByIdAsync(model.LessonId);
            return RedirectToAction(nameof(ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ByMe(string searchString, int? pageNumber)
        {
            IEnumerable<LessonViewModel> models = await this.lessonsService.GetCreatedByMeAsync(GetUserId(), searchString);
            var paginated = PaginatedList<LessonViewModel>.Create(models.OrderByDescending(x => x.LessonId), pageNumber ?? DefaultPageNumber, DefaultPageSize);
            paginated.SearchString = searchString;
            return View(paginated);
        }

        [HttpGet]
        public async Task<IActionResult> ByCategory(string categoryName, string searchString, int grade, int? pageNumber)
        {
            var lessons = await this.lessonsService.GetLessonsByCategoryAndGradeAsync(categoryName, searchString, grade);
            var paginated = PaginatedList<LessonViewModel>.Create(lessons.OrderByDescending(x => x.LessonId), pageNumber ?? DefaultPageNumber, DefaultPageSize);
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
    }
}
