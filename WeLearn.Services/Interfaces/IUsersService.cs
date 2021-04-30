using System.Threading.Tasks;

namespace WeLearn.Services.Interfaces
{
    public interface IUsersService
    {
        Task<int> GetAllUsersCountAsync();
    }
}
