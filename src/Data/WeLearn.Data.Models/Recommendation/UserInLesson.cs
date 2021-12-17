using Microsoft.ML.Data;

namespace WeLearn.Data.Models.Recommendation
{
    public class UserInLesson
    {
        [LoadColumn(0)]
        public string UserId { get; set; }

        [LoadColumn(1)]
        public int LessonId { get; set; }

        [LoadColumn(2)]
        public float Label { get; set; }
    }
}
