using WeLearn.Data.Models;

namespace WeLearn.Data.Repositories
{
    public class CategoryRepository : EfDeletableEntityRepository<Category>
    {
        public CategoryRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
