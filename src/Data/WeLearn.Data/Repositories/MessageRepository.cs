using WeLearn.Data.Models.ChatApp;

namespace WeLearn.Data.Repositories
{
    public class MessageRepository : EfRepository<Message>
    {
        public MessageRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
