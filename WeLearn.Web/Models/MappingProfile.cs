using AutoMapper;

using WeLearn.Data.Models;
using WeLearn.Infrastructure.ViewModels;

namespace WeLearn.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<Post, Post>();

            CreateMap<PostInputModel, Post>()
                .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.PostName))
                .ForMember(dest => dest.PostName, opt => opt.MapFrom(src => src.PostName))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.VideoId, opt => opt.Ignore())
                .ForMember(dest => dest.Video, opt => opt.Ignore())
                .ForMember(dest => dest.MaterialId, opt => opt.Ignore())
                .ForMember(dest => dest.Material, opt => opt.Ignore());

            CreateMap<Post, PostEditModel>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.ApplicationUserId))
                .ForMember(dest => dest.PostId, opt => opt.MapFrom(src => src.PostId))
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.PostName))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.OldVideoLink, opt => opt.MapFrom(src => src.Video.Link))
                .ForMember(dest => dest.OldFilesLink, opt => opt.MapFrom(src => src.Material.Link))
                .ForMember(dest => dest.Video, opt => opt.Ignore())
                .ForMember(dest => dest.Files, opt => opt.Ignore());

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
                .ForMember(dest => dest.VideoContentType, opt => opt.MapFrom(src => src.Video.VideoContentType))
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

            CreateMap<Comment, CommentViewModel>()
                .ForMember(dest => dest.PostId, opt => opt.MapFrom(src => src.PostId))
                .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.ApplicationUserId))
                .ForMember(dest => dest.CommentContent, opt => opt.MapFrom(src => src.Content))
                .ForMember(dest => dest.DateCreated, opt => opt.MapFrom(src => src.DateCreated))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName));

            CreateMap<CommentViewModel, Comment>()
                .ForMember(dest => dest.PostId, opt => opt.MapFrom(src => src.PostId))
                .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.ApplicationUserId))
                .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.CommentContent));

            // problematic mapping when editing a comment
            CreateMap<Comment, CommentMultiModel>()
                .ForMember(dest => dest.CommentId, opt => opt.MapFrom(src => src.CommentId))
                .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.ApplicationUserId))
                .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
                .ForMember(dest => dest.PostId, opt => opt.MapFrom(src => src.PostId))
                .ForMember(dest => dest.PostName, opt => opt.MapFrom(src => src.Post.PostName))
                .ForMember(dest => dest.PostVideoLink, opt => opt.MapFrom(src => src.Post.Video.Link))
                .ForMember(dest => dest.PostVideoName, opt => opt.MapFrom(src => src.Post.Video.VideoName))
                .ForMember(dest => dest.PostVideoContentType, opt => opt.MapFrom(src => src.Post.Video.VideoContentType))
                .ForMember(dest => dest.PostZippedFileLink, opt => opt.MapFrom(src => src.Post.Material.Link))
                .ForMember(dest => dest.PostCreatedByUsername, opt => opt.MapFrom(src => src.Post.ApplicationUser.UserName))
                .ForMember(dest => dest.PostGrade, opt => opt.MapFrom(src => src.Post.Grade))
                .ForMember(dest => dest.PostDescription, opt => opt.MapFrom(src => src.Post.Description))
                .ForMember(dest => dest.PostCategoryName, opt => opt.MapFrom(src => src.Post.Category.CategoryName));

            CreateMap<CommentMultiModel, Comment>()
                .ForMember(dest => dest.CommentId, opt => opt.MapFrom(src => src.CommentId))
                .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
                .ForMember(dest => dest.PostId, opt => opt.MapFrom(src => src.PostId))
                .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.ApplicationUserId));

            CreateMap<Category, Category>();
            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryViewModel, Category>();
        }
    }
}
