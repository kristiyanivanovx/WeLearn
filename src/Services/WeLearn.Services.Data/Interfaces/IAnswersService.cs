using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Web.ViewModels.Answer;

namespace WeLearn.Services.Data.Interfaces
{
    public interface IAnswersService
    {
        IEnumerable<T> GetAll<T>();

        bool Contains(int id);

        T GetById<T>(int id);

        Task<int> CreateAsync(AnswerInputModel model);

        Task<int> EditAsync(AnswerEditModel model);

        Task DeleteAsync(int id);
    }
}
