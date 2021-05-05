using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Data.Models;

namespace WeLearn.Services.Interfaces
{
    public interface ICategoriesService
    {
        Task<int> GetAllCategoriesCountAsync();

        Task<IEnumerable<Category>> GetAllCategoriesAsync();
    }
}
