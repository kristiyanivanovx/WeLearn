using WeLearn.Data.Models;

namespace WeLearn.Data.Repositories
{
    public class ApplicationUserRepository : EfDeletableEntityRepository<ApplicationUser>
    {
        public ApplicationUserRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
