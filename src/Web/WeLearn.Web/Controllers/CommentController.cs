using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Interfaces;
using WeLearn.Web.ViewModels.Comment;
using WeLearn.Web.ViewModels.Lesson;

namespace WeLearn.Web.Controllers
{
    public class CommentController : BaseController
    {
        private readonly ICommentsService commentsService;

        public CommentController(ICommentsService commentsService)
            => this.commentsService = commentsService;

        [HttpGet]
        public IActionResult Create() => RedirectToAction("All", "Lesson");

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CommentInputModel commentViewModel)
        {
            commentViewModel.ApplicationUserId = GetUserId();

            if (!ModelState.IsValid)
            {
                return View("~/Views/Lesson/Watch.cshtml", new LessonViewModel { LessonId = commentViewModel.LessonId });
            }

            await this.commentsService.CreateCommentAsync(commentViewModel);
            return RedirectToAction(nameof(ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            CommentEditModel comment = await this.commentsService.GetCommentByIdWithDeletedAsync<CommentEditModel>(id);
            return View(comment);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(CommentEditModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.ApplicationUserId != GetUserId())
            {
                return View(nameof(Unauthorized));
            }

            await this.commentsService.EditCommentAsync(model);
            return RedirectToAction(nameof(ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var commentModel = await this.commentsService.GetCommentByIdWithDeletedAsync<CommentDeleteModel>(id);
            return View(commentModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(CommentDeleteModel model)
        {
            if (model.ApplicationUserId != GetUserId())
            {
                return View("Unauthorized");
            }

            await this.commentsService.SoftDeleteCommentByIdAsync(model.Id);
            return RedirectToAction(nameof(ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ByMe()
        {
            IEnumerable<CommentByMeModel> commentByMe = await this.commentsService.GetCommentsMadeByMeAsync(GetUserId());
            return View(commentByMe);
        }
    }
}
