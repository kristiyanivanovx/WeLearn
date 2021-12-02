using System.Collections.Generic;

using WeLearn.Web.ViewModels.Category;

namespace WeLearn.Web.ViewModels.Lesson
{
    public class LessonsNavigationDropdownModel
    {
        public IEnumerable<CategoryViewModel> Categories { get; set; }

        public IEnumerable<LessonViewModel> Lessons { get; set; }
    }
}
