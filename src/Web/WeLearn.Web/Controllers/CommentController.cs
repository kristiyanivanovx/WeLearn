using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Web.ViewModels.Comment;

namespace WeLearn.Web.Controllers
{
    public class CommentController : BaseController
    {
        private readonly ICommentsService commentsService;

        public CommentController(ICommentsService commentsService)
            => this.commentsService = commentsService;

        [HttpGet]
        public IActionResult Create() => this.RedirectToAction("All", "Lesson");

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CommentInputModel commentViewModel)
        {
            commentViewModel.UserId = this.GetUserId();
            var id = new { id = commentViewModel.LessonId };

            if (!this.ModelState.IsValid)
            {
                // var changedModel = new LessonViewModel { LessonId = commentViewModel.LessonId };
                return this.RedirectToAction("Watch", "Lesson", id);
            }

            await this.commentsService.CreateCommentAsync(commentViewModel);
            return this.RedirectToAction("Watch", "Lesson", id);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            CommentEditModel comment = await this.commentsService.GetCommentByIdWithDeletedAsync<CommentEditModel>(id);
            return this.View(comment);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(CommentEditModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            if (model.UserId != this.GetUserId())
            {
                return this.View(nameof(this.Unauthorized));
            }

            await this.commentsService.EditCommentAsync(model);
            return this.RedirectToAction(nameof(this.ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var commentModel = await this.commentsService.GetCommentByIdWithDeletedAsync<CommentDeleteModel>(id);
            return this.View(commentModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(CommentDeleteModel model)
        {
            if (model.UserId != this.GetUserId())
            {
                return this.View("Unauthorized");
            }

            await this.commentsService.SoftDeleteCommentByIdAsync(model.Id);
            return this.RedirectToAction(nameof(this.ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ByMe()
        {
            IEnumerable<CommentByMeModel> commentByMe = await this.commentsService.GetCommentsMadeByMeAsync(this.GetUserId());
            return this.View(commentByMe);
        }
    }
}
