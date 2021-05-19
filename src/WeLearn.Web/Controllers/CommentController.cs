using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using WeLearn.Data.Models;
using WeLearn.Web.Infrastructure;
using WeLearn.ViewModels;
using WeLearn.Services.Interfaces;
using System.Collections.Generic;

namespace WeLearn.Web.Controllers
{
    public class CommentController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ICommentsService commentsService;

        public CommentController(
            UserManager<ApplicationUser> userManager,
            IHttpContextAccessor httpContextAccessor,
            ICommentsService commentsService)
        {
            this.userManager = userManager;
            this.httpContextAccessor = httpContextAccessor;
            this.commentsService = commentsService;
        }

        [HttpGet]
        public IActionResult Create() => RedirectToAction("All", "Lesson");

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CommentViewModel commentViewModel)
        {
            commentViewModel.ApplicationUserId = GetUserId();

            if (!ModelState.IsValid)
            {
                return View("~/Views/Lesson/Watch.cshtml", new LessonViewModel { LessonId = commentViewModel.LessonId });
            }

            await commentsService.CreateCommentAsync(commentViewModel);
            return RedirectToAction(nameof(ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            CommentMultiModel comment = await commentsService.GetCommentByIdAsync<CommentMultiModel>(id);
            return View(comment);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(CommentMultiModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (GetUserId() != model.ApplicationUserId)
            {
                return View(nameof(Unauthorized));
            }

            await commentsService.EditCommentAsync(model);
            return RedirectToAction(nameof(ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            CommentMultiModel commentModel = await commentsService.GetCommentByIdAsync<CommentMultiModel>(id);
            return View(commentModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(CommentMultiModel model)
        {
            if (GetUserId() != model.ApplicationUserId)
            {
                return View("Unauthorized");
            }

            await commentsService.SoftDeleteCommentByIdAsync(model.CommentId);
            return RedirectToAction(nameof(ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ByMe()
        {
            IEnumerable<CommentMultiModel> myComments = await commentsService.GetCommentsMadeByMeAsync(GetUserId());
            return View(myComments);
        }
    }
}
