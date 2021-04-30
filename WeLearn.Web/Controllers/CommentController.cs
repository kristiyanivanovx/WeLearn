using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WeLearn.Data.Context;
using WeLearn.Data.Models;
using WeLearn.Infrastructure.ViewModels;
using WeLearn.Services.Interfaces;

namespace WeLearn.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ICommentsService commentsService;

        public CommentController(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            IHttpContextAccessor httpContextAccessor,
            ICommentsService commentsService)
        {
            this.context = context;
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
                return View("~/Views/Lesson/Watch.cshtml", new PostViewModel { PostId = commentViewModel.PostId });
            }

            // abstract this away
            var post = context.Posts.FirstOrDefault(x => x.PostId == commentViewModel.PostId);
            var comment = new Comment { PostId = post.PostId, Content = commentViewModel.CommentContent, ApplicationUserId = userId };
            await context.Comments.AddAsync(comment);
            await context.SaveChangesAsync();

            return View("ThankYou");
        }

        //finish up here
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            var post = await commentsService.GetCommentByIdAsync<CommentMultiModel>(id);

            if (user.Id != post.ApplicationUserId)
            {
                return View(nameof(Unauthorized));
            }

            return View(post);
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

            await commentsService.DeleteCommentByIdAsync(comment.CommentId);
            return View("Deleted");
        }

        [Authorize]
        public async Task<IActionResult> ByMe()
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var myComments = await commentsService.UploadedByMeAsync<CommentMultiModel>(userId);
            return View(myComments);
        }
    }
}
