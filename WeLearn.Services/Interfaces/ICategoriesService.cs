using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.ViewModels;

namespace WeLearn.Services.Interfaces
{
    public interface ICategoriesService
    {
        Task<int> GetAllCategoriesCountAsync();

        IEnumerable<CategoryViewModel> GetAllCategories();
    }
}
