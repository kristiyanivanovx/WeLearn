using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WeLearn.Services.Interfaces;

namespace WeLearn.Web.Components
{
    public class AllComments : ViewComponent
    {
        private readonly IViewComponentsService viewComponentsService;

        public AllComments(IViewComponentsService viewComponentsService)
        {
            this.viewComponentsService = viewComponentsService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int lessonId)
        {
            var commentViewModels = await viewComponentsService.GenerateCommentViewModelsAsync(lessonId);
            return View(commentViewModels);
        }
    }
}
