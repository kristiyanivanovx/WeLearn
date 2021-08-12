using System.Collections.Generic;
using WeLearn.ViewModels.Category;

namespace WeLearn.Services.Interfaces
{
    public interface ICategoriesService
    {
        int GetAllCategoriesCount();

        IEnumerable<CategoryViewModel> GetAllCategories();
    }
}
