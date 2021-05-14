﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using WeLearn.ViewModels;
using WeLearn.Services;
using WeLearn.Services.Interfaces;
using System.Collections.Generic;
using WeLearn.Data.Models;

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

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> LessonsByMe()
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            IEnumerable<LessonReportModel> myReports = await reportsService.GetLessonReportsCreatedByMeAsync(userId);
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
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            lessonReportModel.ReportingUserId = userId;

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
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (!ModelState.IsValid)
            {
                return View(lessonReportModel);
            }

            if (lessonReportModel.ReportingUserId != userId)
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
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (lessonReportModel.ReportingUserId != userId)
            {
                return View("Unauthorized");
            }

            await reportsService.SoftDeleteReportByIdAsync(lessonReportModel.ReportId);
            return RedirectToAction(nameof(LessonsByMe));
        }

        [Authorize]
        public async Task<IActionResult> CommentsByMe()
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            IEnumerable<CommentReportModel> myReports = await reportsService.GetCommentReportsCreatedByMeAsync(userId);
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
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            commentReportModel.ReportingUserId = userId;

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
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (!ModelState.IsValid)
            {
                return View(commentReportModel);
            }

            if (commentReportModel.ReportingUserId != userId)
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
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (commentReportModel.ReportingUserId != userId)
            {
                return View(nameof(Unauthorized));
            }

            await reportsService.SoftDeleteReportByIdAsync(commentReportModel.ReportId);
            return RedirectToAction(nameof(CommentsByMe));
        }
    }
}
