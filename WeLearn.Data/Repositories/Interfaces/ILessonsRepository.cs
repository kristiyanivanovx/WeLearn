using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeLearn.Data.Models;

namespace WeLearn.Data.Repositories.Interfaces
{
    public interface ILessonsRepository
    {
        Task<List<Lesson>> GetWithIncludes();
    }
}
