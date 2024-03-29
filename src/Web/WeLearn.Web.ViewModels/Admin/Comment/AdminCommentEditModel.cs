﻿using System;
using System.ComponentModel.DataAnnotations;

using Ganss.XSS;
using WeLearn.Data.Models.Enums;
using WeLearn.Services.Mapping;

using static WeLearn.Data.Common.Validation.DataValidation.Comment;

namespace WeLearn.Web.ViewModels.Admin.Comment
{
    public class AdminCommentEditModel : IMapFrom<Data.Models.LessonModule.Comment>
    {
        public int Id { get; set; }

        [Display(Name = "Content")]
        [Required(ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        [MaxLength(MaxContentLength, ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        public string Content { get; set; }

        public string SanitizedCommentContent => new HtmlSanitizer().Sanitize(this.Content);

        [Display(Name = "Is deleted")]
        public bool IsDeleted { get; set; }

        public string UserId { get; set; }

        public string UserUserName { get; set; }

        public int LessonId { get; set; }

        [Display(Name = "Date created")]
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
