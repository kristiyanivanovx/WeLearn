using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Interfaces;
using WeLearn.ViewModels;

namespace WeLearn.Web.ViewComponents
{
    public class LessonsNavigatorDropdown : ViewComponent
    {
        private readonly IViewComponentsService viewComponentsService;

        public LessonsNavigatorDropdown(IViewComponentsService viewComponentsService)
            => this.viewComponentsService = viewComponentsService;

        public IViewComponentResult Invoke()
        {
            LessonsNavigationDropdownModel lessonsNavigationDropdownModel = viewComponentsService.GenerateDropdownModel();
            return View(lessonsNavigationDropdownModel);
        }
    }
}
