using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Data.Models;
using WeLearn.Data.Repositories.Interfaces;

namespace WeLearn.Data.Repositories
{
    public class LessonRepository : Repository<Lesson>, ILessonsRepository
    {
        public LessonRepository(ApplicationDbContext context) : base (context) { }

        public Task<List<Lesson>> GetWithIncludes()
        {
            return context.Set<Lesson>()
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .ToListAsync();
        }
    }
}
