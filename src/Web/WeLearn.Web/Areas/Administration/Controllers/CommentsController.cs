using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Interfaces;
using WeLearn.Web.ViewModels.Admin.Comment;
using WeLearn.Web.ViewModels.HelperModels;

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
            return this.View(paginated);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            AdminCommentEditModel comment = await this.commentsService.GetCommentByIdWithDeletedAsync<AdminCommentEditModel>(id);
            return this.View(comment);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, AdminCommentEditModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            await this.commentsService.EditCommentByAdminAsync(model);
            return this.RedirectToAction(nameof(this.Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            AdminCommentDeleteModel comment = await this.commentsService.GetCommentByIdWithDeletedAsync<AdminCommentDeleteModel>(id);
            return this.View(comment);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.commentsService.HardDeleteCommentByIdAsync(id);
            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
