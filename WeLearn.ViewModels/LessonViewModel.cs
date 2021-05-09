using WeLearn.Data.Models.Enums;

namespace WeLearn.ViewModels
{
    public class LessonViewModel
    {
        public int LessonId { get; set; }

        public string LessonName { get; set; }

        public string Description { get; set; }

        public Grade Grade { get; set; }

        public string CategoryName { get; set; }

        public string CreatedByUserName { get; set; }

        public string VideoName { get; set; }

        public string VideoContentType { get; set; }

        public string VideoLink { get; set; }

        public string ZippedFile { get; set; }
    }
}
