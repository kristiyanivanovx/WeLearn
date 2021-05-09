using System.Collections.Generic;
using WeLearn.Data.Models;

namespace WeLearn.ViewModels
{
    public class LessonsNavigationDropdownModel
    {
        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<Lesson> Lessons { get; set; }
    }
}
