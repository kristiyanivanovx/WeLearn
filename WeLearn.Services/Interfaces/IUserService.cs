using System.Threading.Tasks;

namespace WeLearn.Services.Interfaces
{
    public interface IUserService
    {
        Task<int> GetAllUsersCountAsync();
    }
}
