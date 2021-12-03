using WeLearn.Data.Models;

namespace WeLearn.Data.Repositories
{
    public class PrivateMessageRepository : EfDeletableEntityRepository<PrivateMessage>
    {
        public PrivateMessageRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
