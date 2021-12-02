using System;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using WeLearn.Data.Models.Enums;
using WeLearn.Services.Mapping;

namespace WeLearn.Web.ViewModels.Lesson
{
    public class LessonSendEmailViewModel : IMapFrom<Data.Models.Lesson>, IHaveCustomMappings
    {
        public int LessonId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Grade Grade { get; set; }

        [Display(Name = "Date created")]
        public DateTime CreatedOn { get; set; }

        public string CategoryName { get; set; }

        public string ApplicationUserUserName { get; set; }

        public string VideoName { get; set; }

        public string VideoContentType { get; set; }

        public string VideoLink { get; set; }

        public string MaterialLink { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Your email")]
        public string Email { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Data.Models.Lesson, LessonSendEmailViewModel>()
                .ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.Id));

        }
    }
}
