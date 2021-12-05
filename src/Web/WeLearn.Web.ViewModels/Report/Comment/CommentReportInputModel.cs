using System;
using System.ComponentModel.DataAnnotations;

using AutoMapper;
using WeLearn.Services.Mapping;

using static WeLearn.Data.Common.Validation.DataValidation.Report;

namespace WeLearn.Web.ViewModels.Report.Comment
{
    public class CommentReportInputModel : IMapFrom<Data.Models.Comment>, IMapTo<Data.Models.Report>, IHaveCustomMappings
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

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Data.Models.Comment, CommentReportInputModel>()
                .ForMember(dest => dest.CommentId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CommentContent, opt => opt.MapFrom(src => src.Content))
                .ForMember(dest => dest.CommentCreatedOn, opt => opt.MapFrom(src => src.CreatedOn))
                .ForMember(
                    dest => dest.CommentApplicationUserUserName,
                    opt => opt.MapFrom(src => src.ApplicationUser.UserName));

            configuration.CreateMap<CommentReportInputModel, Data.Models.Report>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ReportId))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.ReportDescription));
        }
    }
}
