using System;

using Ganss.XSS;
using WeLearn.Data.Models.Enums;
using WeLearn.Services.Mapping;

namespace WeLearn.Web.ViewModels.Comment
{
    public class CommentDeleteModel : IMapFrom<Data.Models.LessonModule.Comment>
    {
        public int Id { get; set; }

        public int LessonId { get; set; }

        public string Content { get; set; }

        public string SanitizedContent => new HtmlSanitizer().Sanitize(this.Content);

        public int LessonLikesCount { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserId { get; set; }

        public DateTime LessonCreatedOn { get; set; }

        public string LessonName { get; set; }

        public string LessonDescription { get; set; }

        public Grade LessonGrade { get; set; }

        public string LessonCategoryName { get; set; }

        public string LessonVideoLink { get; set; }

        public string LessonVideoName { get; set; }

        public string LessonVideoContentType { get; set; }

        public string LessonMaterialLink { get; set; }

        public string LessonApplicationUserUserName { get; set; }
    }
}
