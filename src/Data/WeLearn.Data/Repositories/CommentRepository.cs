using WeLearn.Data.Models;

namespace WeLearn.Data.Repositories
{
    public class CommentRepository : EfDeletableEntityRepository<Comment>
    {
        public CommentRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
