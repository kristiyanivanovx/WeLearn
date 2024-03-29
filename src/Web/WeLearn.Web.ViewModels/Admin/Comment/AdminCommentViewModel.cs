﻿using System;
using System.ComponentModel.DataAnnotations;

using AutoMapper;
using Ganss.XSS;
using WeLearn.Data.Models.Enums;
using WeLearn.Services.Mapping;

using static WeLearn.Data.Common.Validation.DataValidation.Comment;

namespace WeLearn.Web.ViewModels.Admin.Comment
{
    public class AdminCommentViewModel : IMapFrom<Data.Models.LessonModule.Comment>, IHaveCustomMappings
    {
        public string UserUserName { get; set; }

        public string UserEmail { get; set; }

        public string UserId { get; set; }

        [Display(Name = "Is deleted")]
        public bool IsDeleted { get; set; }

        public int CommentId { get; set; }

        public int LessonId { get; set; }

        public string Content { get; set; }

        public string SanitizedCommentContent => new HtmlSanitizer().Sanitize(this.Content);

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

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Data.Models.LessonModule.Comment, AdminCommentViewModel>()
                .ForMember(
                    dest => dest.CommentId,
                    opt =>
                        opt.MapFrom(src => src.Id));
        }
    }
}
