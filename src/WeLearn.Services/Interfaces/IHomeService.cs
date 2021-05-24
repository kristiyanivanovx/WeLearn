using System.Threading.Tasks;
using WeLearn.ViewModels;
using WeLearn.ViewModels.Index;

namespace WeLearn.Services.Interfaces
{
    public interface IHomeService
    {
        IndexViewModel GenerateIndexViewModel();
    }
}
