using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Data.Models.Quiz;
using WeLearn.Web.ViewModels.Question;

namespace WeLearn.Services.Data.Interfaces
{
    public interface IQuestionsService
    {
        Task CreateAsync(QuestionInputModel model);

        Task DeleteAsync(int id);

        Task EditAsync(QuestionEditModel model);

        bool Contains(int id);

        IEnumerable<Question> GetAllWithAnswers();

        Question GetById(int id);

        IEnumerable<T> GetAll<T>();

        T GetById<T>(int id);
    }
}
