using System.Threading.Tasks;

using WeLearn.Web.ViewModels.Admin;
using WeLearn.Web.ViewModels.Home;

namespace WeLearn.Services.Interfaces
{
    public interface IInformationService
    {
        IndexViewModel GenerateIndexViewModel();

        Task<AdministrationIndexViewModel> GenerateAdministrationIndexViewModel(string userId);

        FrequentQuestionsViewModel GenerateFrequentQuestionsViewModel();
    }
}
