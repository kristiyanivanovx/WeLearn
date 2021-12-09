using WeLearn.Web.ViewModels.Admin;
using WeLearn.Web.ViewModels.Home;

namespace WeLearn.Services.Interfaces
{
    public interface IInformationService
    {
        IndexViewModel GenerateIndexViewModel();

        AdministrationIndexViewModel GenerateAdministrationIndexViewModel();

        FrequentQuestionsViewModel GenerateFrequentQuestionsViewModel();
    }
}
