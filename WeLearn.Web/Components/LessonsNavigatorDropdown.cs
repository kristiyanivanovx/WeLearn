using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Interfaces;

namespace WeLearn.Web.Components
{
    public class LessonsNavigatorDropdown : ViewComponent
    {
        private readonly IViewComponentsService viewComponentsService;

        public LessonsNavigatorDropdown(IViewComponentsService viewComponentsService)
        {
            this.viewComponentsService = viewComponentsService;
        }

        public IViewComponentResult Invoke()
        {
            var lessonsNavigationDropdownModel = viewComponentsService.GenerateDropdownModel();
            return View(lessonsNavigationDropdownModel);
        }
    }
}
