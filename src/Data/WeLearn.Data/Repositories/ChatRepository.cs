using WeLearn.Data.Models.ChatApp;

namespace WeLearn.Data.Repositories
{
    public class ChatRepository : EfRepository<Chat>
    {
        public ChatRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
