using System.Threading.Tasks;
using WeLearn.ViewModels;

namespace WeLearn.Services.Interfaces
{
    public interface IHomeService
    {
        Task<IndexViewModel> GenerateIndexViewModelAsync();
    }
}
