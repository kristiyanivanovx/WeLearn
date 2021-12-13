using WeLearn.Services.Mapping;

namespace WeLearn.Web.ViewModels.Like
{
    public class LikeInputModel : IMapTo<Data.Models.LessonModule.Like>
    {
        public int LessonId { get; set; }
    }
}
