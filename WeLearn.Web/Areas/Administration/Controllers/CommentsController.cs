using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Interfaces;
using WeLearn.ViewModels;
using WeLearn.ViewModels.HelperModels;
using System.Linq;
using System.Collections.Generic;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Authorize(Roles = "Admin")]
    public class CommentsController : Controller
    {
        private readonly ICommentsService commentsService;

        public CommentsController(ICommentsService commentsService)
            => this.commentsService = commentsService;

        [HttpGet]
        public async Task<IActionResult> Index(string searchString, int? pageNumber)
        {
            ViewData["SearchString"] = searchString;
            var allComments = await commentsService.GetAllCommentsAsync(searchString);
            var paginated = PaginatedList<AdministrationCommentModel>.Create(allComments.OrderBy(x => x.IsDeleted), pageNumber ?? 1, 6);
            return View(paginated);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            AdministrationCommentModel comment = await commentsService.GetCommentByIdAsync<AdministrationCommentModel>(id);
            return View(comment);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, AdministrationCommentModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await commentsService.EditCommentByAdminAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            AdministrationCommentModel comment = await commentsService.GetCommentByIdAsync<AdministrationCommentModel>(id);
            return View(comment);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await commentsService.HardDeleteCommentByIdAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
