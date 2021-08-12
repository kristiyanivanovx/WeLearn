using WeLearn.ViewModels.Home;

namespace WeLearn.Services.Interfaces
{
    public interface IHomeService
    {
        IndexViewModel GenerateIndexViewModel();

        FrequentQuestionsViewModel GenerateFrequentQuestionsViewModel();
    }
}
