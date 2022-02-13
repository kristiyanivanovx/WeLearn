using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Data.Models.Quiz;
using WeLearn.Web.ViewModels.Quiz;

namespace WeLearn.Services.Data.Interfaces
{
    public interface IQuizzesService
    {
        Task CreateAsync(QuizInputModel model);

        Task DeleteAsync(int id);

        Task EditAsync(QuizEditModel model);

        int GetCount();

        bool Contains(int id);

        IEnumerable<T> GetById<T>(int id);

        IEnumerable<T> GetAll<T>();

        Quiz GetQuizById(int id);
    }
}
