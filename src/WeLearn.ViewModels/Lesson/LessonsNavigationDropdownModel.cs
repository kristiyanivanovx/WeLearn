using System.Collections.Generic;
using WeLearn.ViewModels.Category;

namespace WeLearn.ViewModels.Lesson
{
    public class LessonsNavigationDropdownModel
    {
        public IEnumerable<CategoryViewModel> Categories { get; set; }

        public IEnumerable<LessonViewModel> Lessons { get; set; }
    }
}
