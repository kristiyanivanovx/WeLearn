using WeLearn.Data.Models;
using WeLearn.Services.Mapping;

namespace WeLearn.Web.ViewModels.Likes
{
    public class LikeInputModel : IMapTo<Like>
    {
        public int LessonId { get; set; }
    }
}
