using WeLearn.Data.Models;

namespace WeLearn.Data.Repositories
{
    public class MaterialRepository : EfDeletableEntityRepository<Material>
    {
        public MaterialRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
