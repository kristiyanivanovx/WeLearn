using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Interfaces;
using System.Collections.Generic;
using WeLearn.ViewModels;
using WeLearn.ViewModels.HelperModels;
using System.Linq;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Authorize(Roles = "Admin")]
    public class CommentsController : Controller
    {
        private readonly ICommentsService commentsService;

        public CommentsController(ICommentsService commentsService)
            => this.commentsService = commentsService;

        // GET: Administration/Comments
        public async Task<IActionResult> Index(string searchString, int? pageNumber)
        {
            ViewData["CurrentFilter"] = searchString;
            var allComments = await commentsService.GetAllComments(searchString);
            var paginated = PaginatedList<CommentAdministrationModel>.Create(allComments.OrderBy(x => x.LessonId), pageNumber ?? 1, 6);
            return View(paginated);
        }

        // GET: Administration/Comments/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            CommentAdministrationModel comment = await commentsService.GetCommentByIdAsync<CommentAdministrationModel>(id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // POST: Administration/Comments/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(int id, CommentAdministrationModel model)
        {
            if (id != model.CommentId)
            {
                return NotFound();
            }

            await commentsService.EditCommentByAdminAsync(model);
            return RedirectToAction(nameof(Index));
        }

        // GET: Administration/Comments/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            CommentAdministrationModel comment = await commentsService.GetCommentByIdAsync<CommentAdministrationModel>(id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // POST: Administration/Comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await commentsService.HardDeleteCommentByIdAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
