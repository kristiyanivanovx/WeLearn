using System;
using System.ComponentModel.DataAnnotations;
using Ganss.XSS;
using WeLearn.Data.Models.Enums;
using WeLearn.Services.Mapping;

using static WeLearn.Data.Common.Validation.DataValidation.Comment;

namespace WeLearn.Web.ViewModels.Admin.Comment
{
    public class AdminCommentDeleteModel : IMapFrom<Data.Models.LessonModule.Comment>
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string SanitizedCommentContent => new HtmlSanitizer().Sanitize(this.Content);

        public string UserUserName { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LessonCreatedOn { get; set; }

        public string LessonName { get; set; }

        public string LessonDescription { get; set; }

        public Grade LessonGrade { get; set; }

        public string LessonCategoryName { get; set; }

        public string LessonVideoLink { get; set; }

        public string LessonVideoName { get; set; }

        public string LessonVideoContentType { get; set; }

        public string LessonMaterialLink { get; set; }

        public string LessonUserUserName { get; set; }
    }
}
