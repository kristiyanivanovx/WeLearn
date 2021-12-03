using WeLearn.Data.Common.Validation;
using WeLearn.Data.Models;
using WeLearn.Data.Models.ChatApp;
using WeLearn.Data.Repositories;

namespace WeLearn.Data.Repositories
{
    public class LessonRepository : EfDeletableEntityRepository<Lesson>
    {
        public LessonRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
