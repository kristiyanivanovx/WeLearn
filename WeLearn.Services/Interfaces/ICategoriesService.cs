using System.Collections.Generic;
using System.Threading.Tasks;

namespace WeLearn.Services.Interfaces
{
    public interface ICategoriesService
    {
        Task<int> GetAllCategoriesCountAsync();

        // CategoryViewModel
        Task<IEnumerable<T>> GetAllCategoriesAsync<T>();

        Task<T> GetCategoryByIdAsync<T>(int id);
    }
}
