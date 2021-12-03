using WeLearn.Data.Models;

namespace WeLearn.Data.Repositories
{
    public class ReportRepository : EfDeletableEntityRepository<Report>
    {
        public ReportRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
