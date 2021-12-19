using System;
using System.ComponentModel.DataAnnotations;

using AutoMapper;

using WeLearn.Data.Models.Enums;
using WeLearn.Services.Mapping;

namespace WeLearn.Web.ViewModels.Lesson
{
    public class LessonRecommendedViewModel :
        IMapFrom<Data.Models.LessonModule.Lesson>,
        IMapTo<Data.Models.LessonModule.Lesson>,
        IHaveCustomMappings
    {
        public int LessonId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Grade Grade { get; set; }

        public int LikesCount { get; set; }

        public float RecommendationScore { get; set; }

        [Display(Name = "Date created")]
        public DateTime CreatedOn { get; set; }

        public string CategoryName { get; set; }

        public string ApplicationUserId { get; set; }

        public string ApplicationUserUserName { get; set; }

        public string VideoName { get; set; }

        public string VideoContentType { get; set; }

        public string VideoLink { get; set; }

        public string MaterialLink { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<LessonViewModel, Data.Models.LessonModule.Lesson>()
                .ForMember(dest => dest.Id, opt =>
                    opt.MapFrom(src => src.LessonId));

            configuration.CreateMap<Data.Models.LessonModule.Lesson, LessonViewModel>()
                .ForMember(dest => dest.LessonId, opt =>
                    opt.MapFrom(src => src.Id));

            configuration.CreateMap<LessonRecommendedViewModel, Data.Models.LessonModule.Lesson>()
                .ForMember(dest => dest.Id, opt =>
                    opt.MapFrom(src => src.LessonId));

            configuration.CreateMap<Data.Models.LessonModule.Lesson, LessonRecommendedViewModel>()
                .ForMember(dest => dest.LessonId, opt =>
                    opt.MapFrom(src => src.Id));
        }
    }
}
