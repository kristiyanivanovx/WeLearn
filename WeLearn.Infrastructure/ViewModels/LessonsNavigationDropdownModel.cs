using System.Collections.Generic;
using WeLearn.Data.Models;

namespace WeLearn.Infrastructure.ViewModels
{
    public class LessonsNavigationDropdownModel
    {
        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<Lesson> Lessons { get; set; }
    }
}
