using AutoMapper;

using WeLearn.Data.Models;
using WeLearn.Infrastructure.ViewModels;

namespace WeLearn.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           
            CreateMap<PostInputModel, Post>()
                .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.PostName))
                .ForMember(dest => dest.PostName, opt => opt.MapFrom(src => src.PostName))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.VideoId, opt => opt.Ignore())
                .ForMember(dest => dest.Video, opt => opt.Ignore())
                .ForMember(dest => dest.MaterialId, opt => opt.Ignore())
                .ForMember(dest => dest.Material, opt => opt.Ignore());

            // ??
            CreateMap<Post, PostEditModel>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.ApplicationUserId))
                .ForMember(dest => dest.PostId, opt => opt.MapFrom(src => src.PostId))
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.PostName))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.OldVideoLink, opt => opt.MapFrom(src => src.Video.Link))
                .ForMember(dest => dest.OldFilesLink, opt => opt.MapFrom(src => src.Material.Link))
                .ForMember(dest => dest.Video, opt => opt.Ignore())
                .ForMember(dest => dest.Files, opt => opt.Ignore());
            //.ForMember(dest => dest.Video, opt => opt.MapFrom(src => src.Video.Link))
            //.ForMember(dest => dest.Files, opt => opt.MapFrom(src => src.Material.Link))

            CreateMap<PostEditModel, Post>()
                .ForMember(dest => dest.PostId, opt => opt.MapFrom(src => src.PostId))
                .ForMember(dest => dest.PostName, opt => opt.MapFrom(src => src.LessonName));

            CreateMap<Post, PostViewModel>()
                .ForMember(dest => dest.PostId, opt => opt.MapFrom(src => src.PostId))
                .ForMember(dest => dest.PostName, opt => opt.MapFrom(src => src.PostName))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.CreatedByUserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
                .ForMember(dest => dest.VideoName, opt => opt.MapFrom(src => src.Video.VideoName))
                .ForMember(dest => dest.VideoLink, opt => opt.MapFrom(src => src.Video.Link))
                .ForMember(dest => dest.ZippedFile, opt => opt.MapFrom(src => src.Material.Link));

            CreateMap<Post, PostReportModel>()
                .ForMember(dest => dest.PostId, opt => opt.MapFrom(src => src.PostId))
                .ForMember(dest => dest.PostName, opt => opt.MapFrom(src => src.PostName))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
                .ForMember(dest => dest.VideoName, opt => opt.MapFrom(src => src.Video.VideoName))
                .ForMember(dest => dest.VideoLink, opt => opt.MapFrom(src => src.Video.Link))
                .ForMember(dest => dest.ZippedFile, opt => opt.MapFrom(src => src.Material.Link))
                .ForMember(dest => dest.PostApplicationUserUserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName))
                .ForMember(dest => dest.Subject, opt => opt.Ignore())
                .ForMember(dest => dest.ReportDescription, opt => opt.Ignore());

            CreateMap<PostReportModel, Report>()
                .ForMember(dest => dest.ReportId, opt => opt.MapFrom(src => src.ReportId))
                .ForMember(dest => dest.PostId, opt => opt.MapFrom(src => src.PostId))
                .ForMember(dest => dest.Subject, opt => opt.MapFrom(src => src.Subject))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.ReportDescription))
                .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.ReportingUserId));

            CreateMap<Report, PostReportModel>()
                .ForMember(dest => dest.PostId, opt => opt.MapFrom(src => src.PostId))
                .ForMember(dest => dest.ReportId, opt => opt.MapFrom(src => src.ReportId))
                .ForMember(dest => dest.Subject, opt => opt.MapFrom(src => src.Subject))
                .ForMember(dest => dest.ReportDescription, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.PostApplicationUserUserName, opt => opt.MapFrom(src => src.Post.ApplicationUser.UserName))
                .ForMember(dest => dest.PostName, opt => opt.MapFrom(src => src.Post.PostName))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Post.Description))
                .ForMember(dest => dest.Grade, opt => opt.MapFrom(src => src.Post.Grade))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Post.Category.CategoryName))
                .ForMember(dest => dest.VideoLink, opt => opt.MapFrom(src => src.Post.Video.Link))
                .ForMember(dest => dest.VideoName, opt => opt.MapFrom(src => src.Post.Video.VideoName))
                .ForMember(dest => dest.ZippedFile, opt => opt.MapFrom(src => src.Post.Material.Link))
                .ForMember(dest => dest.ReportingUserId, opt => opt.MapFrom(src => src.ApplicationUserId))
                .ForMember(dest => dest.CreatedByUserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName));

            CreateMap<Post, Post>();

            CreateMap<Category, Category>();
            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryViewModel, Category>();
        }
    }
}
