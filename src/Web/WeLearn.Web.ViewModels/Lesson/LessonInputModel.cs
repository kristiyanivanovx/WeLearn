﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using WeLearn.Data.Models.Enums;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Interfaces;
using static WeLearn.Data.Common.Validation.DataValidation.Lesson;

namespace WeLearn.Web.ViewModels.Lesson
{
    public class LessonInputModel : ILessonModel, IMapTo<Data.Models.Lesson>, IHaveCustomMappings
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please add name.")]
        [MaxLength(MaxNameLength)]
        public string LessonName { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please add description.")]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Please pick a category.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please pick a grade.")]
        public Grade Grade { get; set; }

        [Required(ErrorMessage = "Please provide a video.")]
        public IFormFile Video { get; set; }

        [Required(ErrorMessage = "Please provide one or more files, related to the lesson.")]
        public IEnumerable<IFormFile> Files { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            // CreateMap<LessonInputModel, Lesson>()
            configuration.CreateMap<LessonInputModel, Data.Models.Lesson>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.LessonName))
                .ForMember(dest => dest.ApplicationUserId, opt => opt.Ignore())
                .ForMember(dest => dest.Video, opt => opt.Ignore())
                .ForMember(dest => dest.VideoId, opt => opt.Ignore())
                .ForMember(dest => dest.Material, opt => opt.Ignore())
                .ForMember(dest => dest.MaterialId, opt => opt.Ignore());
        }
    }
}
