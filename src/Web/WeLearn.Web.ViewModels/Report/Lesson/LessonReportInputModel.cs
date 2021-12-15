using System;
using System.ComponentModel.DataAnnotations;

using AutoMapper;
using WeLearn.Data.Models.Enums;
using WeLearn.Services.Mapping;

using static WeLearn.Data.Common.Validation.DataValidation.Report;

namespace WeLearn.Web.ViewModels.Report.Lesson
{
    public class LessonReportInputModel :
        IMapFrom<Data.Models.LessonModule.Lesson>,
        IMapTo<Data.Models.LessonModule.Report>,
        IHaveCustomMappings
    {
        public int LessonId { get; set; }

        public int ReportId { get; set; }

        public int LikesCount { get; set; }

        public string LessonName { get; set; }

        public DateTime CreatedOn { get; set; }

        public string LessonApplicationUserUserName { get; set; }

        public string LessonDescription { get; set; }

        public Grade LessonGrade { get; set; }

        public string LessonCategoryName { get; set; }

        public string CreatedByUserName { get; set; }

        public DateTime LessonCreatedOn { get; set; }

        public string LessonVideoName { get; set; }

        public string LessonVideoLink { get; set; }

        public string VideoContentType { get; set; }

        public string LessonMaterialLink { get; set; }

        [Required(ErrorMessage = "Please provide subject to the report.")]
        [MaxLength(MaxSubjectLength)]
        public string Subject { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please provide description to the report.")]
        [MaxLength(MaxDescriptionLength)]
        public string ReportDescription { get; set; }

        public string ApplicationUserId { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<LessonReportInputModel, Data.Models.LessonModule.Report>()
                .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(src => src.ReportDescription));

            configuration.CreateMap<Data.Models.LessonModule.Lesson, LessonReportInputModel>()
                .ForMember(
                    dest => dest.LessonId,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(
                    dest => dest.LessonName,
                    opt => opt.MapFrom(src => src.Name))
                .ForMember(
                    dest => dest.LessonGrade,
                    opt => opt.MapFrom(src => src.Grade))
                .ForMember(
                    dest => dest.LessonVideoName,
                    opt => opt.MapFrom(src => src.Video.Name))
                .ForMember(
                    dest => dest.LessonVideoLink,
                    opt => opt.MapFrom(src => src.Video.Link))
                .ForMember(
                    dest => dest.LessonDescription,
                    opt => opt.MapFrom(src => src.Description))
                .ForMember(
                    dest => dest.LessonCreatedOn,
                    opt => opt.MapFrom(src => src.CreatedOn))
                .ForMember(
                    dest => dest.LessonCategoryName,
                    opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(
                    dest => dest.LessonApplicationUserUserName,
                    opt => opt.MapFrom(src => src.ApplicationUser.UserName));
        }
    }
}
