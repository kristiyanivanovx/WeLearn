using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.ViewModels;
using WeLearn.ViewModels.Category;

namespace WeLearn.Services.Interfaces
{
    public interface ICategoriesService
    {
        int GetAllCategoriesCount();

        IEnumerable<CategoryViewModel> GetAllCategories();
    }
}
