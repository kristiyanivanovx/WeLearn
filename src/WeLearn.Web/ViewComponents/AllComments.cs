using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WeLearn.Services.Interfaces;
using WeLearn.ViewModels;
using System.Collections.Generic;

namespace WeLearn.Web.ViewComponents
{
    public class AllComments : ViewComponent
    {
        private readonly IViewComponentsService viewComponentsService;

        public AllComments(IViewComponentsService viewComponentsService)
            => this.viewComponentsService = viewComponentsService;

        public async Task<IViewComponentResult> InvokeAsync(int lessonId)
        {
            IEnumerable<CommentViewModel> commentViewModels = await viewComponentsService.GetCommentsAsync(lessonId);
            return View(commentViewModels);
        }
    }
}
