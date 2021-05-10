using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using WeLearn.Data.Models;
using WeLearn.ViewModels;
using WeLearn.Services.Interfaces;
using System.Collections.Generic;

namespace WeLearn.Web.Controllers
{
    public class CommentController : Controller
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
        public IActionResult Create() => RedirectToAction("Index", "Lesson");

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CommentViewModel commentViewModel)
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            commentViewModel.ApplicationUserId = userId;

            if (!ModelState.IsValid)
            {
                return View("~/Views/Lesson/Watch.cshtml", new LessonViewModel { LessonId = commentViewModel.LessonId });
            }

            await commentsService.CreateCommentAsync(commentViewModel);
            return View("ThankYou");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            CommentMultiModel comment = await commentsService.GetCommentByIdAsync<CommentMultiModel>(id);

            if (userId != comment.ApplicationUserId)
            {
                return View(nameof(Unauthorized));
            }

            return View(comment);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(CommentMultiModel model)
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (userId != model.ApplicationUserId)
            {
                return View(nameof(Unauthorized));
            }

            await commentsService.EditCommentAsync(model);
            return View("ThankYou");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            CommentMultiModel commentModel = await commentsService.GetCommentByIdAsync<CommentMultiModel>(id);

            if (userId != commentModel.ApplicationUserId)
            {
                return View("Unauthorized");
            }

            return View(commentModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(CommentMultiModel model)
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            Comment comment = await commentsService.GetCommentByIdAsync<Comment>(model.CommentId);

            if (userId != comment.ApplicationUserId)
            {
                return View("Unauthorized");
            }

            await commentsService.DeleteCommentAsync(comment);
            return View("Deleted");
        }

        [Authorize]
        public async Task<IActionResult> ByMe()
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            IEnumerable<CommentMultiModel> myComments = await commentsService.CommentsMadeByMeAsync(userId);
            return View(myComments);
        }
    }
}
