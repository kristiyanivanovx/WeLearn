using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

using WeLearn.Data.Models;
using WeLearn.Infrastructure.ViewModels;
using WeLearn.Services.Interfaces;

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
        public IActionResult Create()
        {
            //return View("~/Views/Lesson/Index.cshtml");
            return RedirectToAction("Index", "Lesson");
        }

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
            var user = await userManager.GetUserAsync(HttpContext.User);
            var lesson = await commentsService.GetCommentByIdAsync<CommentMultiModel>(id);

            if (user.Id != lesson.ApplicationUserId)
            {
                return View(nameof(Unauthorized));
            }

            return View(lesson);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(CommentMultiModel commentEditModel)
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (!ModelState.IsValid)
            {
                return View(commentEditModel);
            }

            if (user.Id != commentEditModel.ApplicationUserId)
            {
                return View(nameof(Unauthorized));
            }

            await commentsService.EditCommentAsync(commentEditModel);
            return View("ThankYou");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            var comment = await commentsService.GetCommentByIdAsync<Comment>(id);

            if (user.Id != comment.ApplicationUserId)
            {
                return View("Unauthorized");
            }

            var commentEditModel = await commentsService.GetCommentByIdAsync<CommentMultiModel>(id);
            return View(commentEditModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(CommentMultiModel commentDeleteModel)
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            var comment = await commentsService.GetCommentByIdAsync<Comment>(commentDeleteModel.CommentId);

            if (user.Id != comment.ApplicationUserId)
            {
                return View("Unauthorized");
            }

            await commentsService.DeleteCommentByIdAsync(comment.Id);
            return View("Deleted");
        }

        [Authorize]
        public async Task<IActionResult> ByMe()
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var myComments = await commentsService.MadeByMeToCommentMultiModelAsync(userId);
            return View(myComments);
        }
    }
}
