using WeLearn.Data.Models;

namespace WeLearn.Data.Repositories
{
    public class VideoRepository : EfDeletableEntityRepository<Video>
    {
        public VideoRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
