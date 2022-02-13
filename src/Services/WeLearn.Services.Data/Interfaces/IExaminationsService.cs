using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Data.Models.Quiz;

namespace WeLearn.Services.Data.Interfaces
{
    public interface IExaminationsService
    {
        int GetCount();

        bool Contains(int id);

        Task CreateAsync(int quizId, int points, string userId, List<Choice> choices);

        Examination GetById(int id);

        T GetById<T>(int id);

        IEnumerable<T> GetAll<T>();
    }
}
