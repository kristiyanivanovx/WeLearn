using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Data.Models.Quiz;

namespace WeLearn.Services.Data.Interfaces
{
    public interface IChoicesService
    {
        Task SaveChangesAsync();

        Task<IEnumerable<Choice>> GetAllAsync();

        Task<Choice> CreateAsync(int questionId, int userAnswerId);
    }
}
