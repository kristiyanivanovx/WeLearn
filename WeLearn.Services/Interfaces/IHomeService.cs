using System.Threading.Tasks;
using WeLearn.Infrastructure.ViewModels;

namespace WeLearn.Services.Interfaces
{
    public interface IHomeService
    {
        Task<IndexViewModel> GenerateIndexViewModelAsync();
    }
}
