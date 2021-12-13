using System;
using System.ComponentModel.DataAnnotations;

using AutoMapper;
using WeLearn.Data.Models.Enums;
using WeLearn.Services.Mapping;

using static WeLearn.Data.Common.Validation.DataValidation.Report;

namespace WeLearn.Web.ViewModels.Report.Lesson
{
    public class LessonReportEditModel : IMapFrom<Data.Models.LessonModule.Report>, IHaveCustomMappings
    {
        public int LessonId { get; set; }

        public int ReportId { get; set; }

        public int LessonLikesCount { get; set; }

        public string LessonName { get; set; }

        public DateTime CreatedOn { get; set; }

        public string LessonApplicationUserUserName { get; set; }

        public string LessonDescription { get; set; }

        public Grade LessonGrade { get; set; }

        public string LessonCategoryName { get; set; }

        public string ApplicationUserUserName { get; set; }

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
            configuration.CreateMap<Data.Models.LessonModule.Report, LessonReportEditModel>()
                .ForMember(dest => dest.ReportId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.LessonId))
                .ForMember(dest => dest.ReportDescription, opt => opt.MapFrom(src => src.Description));
        }
    }
}
