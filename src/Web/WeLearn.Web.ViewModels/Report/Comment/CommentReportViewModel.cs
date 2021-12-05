using System;
using System.ComponentModel.DataAnnotations;

using AutoMapper;
using WeLearn.Services.Mapping;

using static WeLearn.Data.Common.Validation.DataValidation.Report;

namespace WeLearn.Web.ViewModels.Report.Comment
{
    public class CommentReportViewModel : IMapFrom<Data.Models.Report>, IHaveCustomMappings
    {
        public int CommentId { get; set; }

        public int ReportId { get; set; }

        public string CommentApplicationUserUserName { get; set; }

        public string CommentContent { get; set; }

        public DateTime CommentCreatedOn { get; set; }

        [MaxLength(MaxSubjectLength)]
        [Required(ErrorMessage = "Please provide subject to the report.")]
        public string Subject { get; set; }

        [MaxLength(MaxDescriptionLength)]
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please provide description to the report.")]
        public string ReportDescription { get; set; }

        public string ApplicationUserId { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ApplicationUserUserName { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Data.Models.Report, CommentReportViewModel>()
                .ForMember(
                    dest => dest.ReportId,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(
                    dest => dest.ReportDescription,
                    opt => opt.MapFrom(src => src.Description));
        }
    }
}
