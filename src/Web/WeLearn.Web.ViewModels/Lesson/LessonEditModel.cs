﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using AutoMapper;
using Microsoft.AspNetCore.Http;
using WeLearn.Data.Models.Enums;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Category;
using WeLearn.Web.ViewModels.Interfaces;

using static WeLearn.Data.Common.Validation.DataValidation.Lesson;

namespace WeLearn.Web.ViewModels.Lesson
{
    public class LessonEditModel : ILessonModel,
        IMapFrom<Data.Models.LessonModule.Lesson>,
        IHaveCustomMappings
    {
        public string UserId { get; set; }

        public int LessonId { get; set; }

        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public Grade Grade { get; set; }

        public int LikesCount { get; set; }

        public string OldVideoLink { get; set; }

        public string OldVideoContentType { get; set; }

        public string OldFilesLink { get; set; }

        public IFormFile Video { get; set; }

        public IEnumerable<IFormFile> Files { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<LessonEditModel, Data.Models.LessonModule.Lesson>()
                .ForMember(
                    dest => dest.Id,
                    opt =>
                        opt.MapFrom(src => src.LessonId));

            // CreateMap<Lesson, LessonEditModel>()
            configuration.CreateMap<Data.Models.LessonModule.Lesson, LessonEditModel>()
                .ForMember(
                    dest => dest.UserId, opt =>
                        opt.MapFrom(src => src.UserId))
                .ForMember(
                    dest => dest.LessonId,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(
                    dest => dest.OldVideoLink,
                    opt => opt.MapFrom(src => src.Video.Link))
                .ForMember(
                    dest => dest.OldFilesLink,
                    opt =>
                        opt.MapFrom(src => src.Material.Link))
                .ForMember(
                    dest =>
                        dest.Video,
                    opt => opt.Ignore())
                .ForMember(
                    dest =>
                        dest.Files,
                    opt => opt.Ignore());
        }
    }
}
