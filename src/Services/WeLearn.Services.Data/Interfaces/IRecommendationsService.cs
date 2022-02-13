using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Data.Models.Recommendation;

namespace WeLearn.Services.Data.Interfaces
{
    public interface IRecommendationsService
    {
        Task TestRecommendationsModel(string modelFile, IEnumerable<UserInLesson> testModelData);
    }
}
