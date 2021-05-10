using System.Collections.Generic;

namespace WeLearn.ViewModels
{
    public class LessonsNavigationDropdownModel
    {
        public IEnumerable<CategoryViewModel> Categories { get; set; }

        public IEnumerable<LessonViewModel> Lessons { get; set; }
    }
}
