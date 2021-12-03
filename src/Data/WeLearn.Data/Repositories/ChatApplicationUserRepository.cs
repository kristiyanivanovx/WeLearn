using WeLearn.Data.Models.ChatApp;

namespace WeLearn.Data.Repositories
{
    public class ChatApplicationUserRepository : EfRepository<ChatApplicationUser>
    {
        public ChatApplicationUserRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
