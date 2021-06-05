using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Interfaces;
using WeLearn.ViewModels;
using WeLearn.ViewModels.HelperModels;
using System.Linq;
using System.Collections.Generic;
using WeLearn.ViewModels.Admin;
using WeLearn.ViewModels.Admin.Comment;
using static WeLearn.Common.Constants;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    public class CommentsController : AdministrationController
    {
        private readonly ICommentsService commentsService;

        public CommentsController(ICommentsService commentsService)
            => this.commentsService = commentsService;

        [HttpGet]
        public async Task<IActionResult> Index(string searchString, int? pageNumber)
        {
            var allComments = await this.commentsService.GetAllCommentsAsync(searchString);
            var paginated = PaginatedList<AdminCommentViewModel>.Create(allComments.OrderBy(x => x.IsDeleted), pageNumber ?? 1, 6);
            paginated.SearchString = searchString;
            return View(paginated);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            AdminCommentEditModel comment = await this.commentsService.GetCommentByIdAsync<AdminCommentEditModel>(id);
            return View(comment);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, AdminCommentEditModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await this.commentsService.EditCommentByAdminAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            AdminCommentDeleteModel comment = await this.commentsService.GetCommentByIdAsync<AdminCommentDeleteModel>(id);
            return View(comment);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.commentsService.HardDeleteCommentByIdAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
