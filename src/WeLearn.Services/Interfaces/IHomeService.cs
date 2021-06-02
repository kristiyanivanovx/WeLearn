using System.Threading.Tasks;
using WeLearn.ViewModels;
using WeLearn.ViewModels.Home;

namespace WeLearn.Services.Interfaces
{
    public interface IHomeService
    {
        IndexViewModel GenerateIndexViewModel();

        FrequentQuestionsViewModel GenerateFrequentQuestionsViewModel();
    }
}
