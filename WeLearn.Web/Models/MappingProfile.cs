using AutoMapper;
using WeLearn.Data.Models;
using WeLearn.ViewModels;

namespace WeLearn.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LessonInputModel, Lesson>()
                .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.LessonName))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.LessonName))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.VideoId, opt => opt.Ignore())
                .ForMember(dest => dest.Video, opt => opt.Ignore())
                .ForMember(dest => dest.MaterialId, opt => opt.Ignore())
                .ForMember(dest => dest.Material, opt => opt.Ignore());

            CreateMap<Lesson, LessonEditModel>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.ApplicationUserId))
                .ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.OldVideoLink, opt => opt.MapFrom(src => src.Video.Link))
                .ForMember(dest => dest.OldFilesLink, opt => opt.MapFrom(src => src.Material.Link))
                .ForMember(dest => dest.Video, opt => opt.Ignore())
                .ForMember(dest => dest.Files, opt => opt.Ignore());

            CreateMap<LessonEditModel, Lesson>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.LessonId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.LessonName));

            CreateMap<Lesson, LessonViewModel>()
                .ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.CreatedByUserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.Grade, opt => opt.MapFrom(src => src.Grade))
                .ForMember(dest => dest.VideoName, opt => opt.MapFrom(src => src.Video.Name))
                .ForMember(dest => dest.VideoLink, opt => opt.MapFrom(src => src.Video.Link))
                .ForMember(dest => dest.VideoContentType, opt => opt.MapFrom(src => src.Video.ContentType))
                .ForMember(dest => dest.ZippedFile, opt => opt.MapFrom(src => src.Material.Link));

            CreateMap<LessonViewModel, Lesson>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.LessonId))
                .ForPath(dest => dest.ApplicationUser.UserName, opt => opt.MapFrom(src => src.CreatedByUserName));

            CreateMap<Lesson, LessonReportModel>()
                .ForMember(dest => dest.OriginId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.VideoName, opt => opt.MapFrom(src => src.Video.Name))
                .ForMember(dest => dest.VideoLink, opt => opt.MapFrom(src => src.Video.Link))
                .ForMember(dest => dest.ZippedFile, opt => opt.MapFrom(src => src.Material.Link))
                .ForMember(dest => dest.OriginApplicationUserUserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName))
                .ForMember(dest => dest.Subject, opt => opt.Ignore())
                .ForMember(dest => dest.ReportDescription, opt => opt.Ignore());

            CreateMap<LessonReportModel, Report>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ReportId))
                .ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.OriginId))
                .ForMember(dest => dest.Subject, opt => opt.MapFrom(src => src.Subject))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.ReportDescription))
                .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.ReportingUserId));

            CreateMap<Report, LessonReportModel>()
                .ForMember(dest => dest.OriginId, opt => opt.MapFrom(src => src.LessonId))
                .ForMember(dest => dest.ReportId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Subject, opt => opt.MapFrom(src => src.Subject))
                .ForMember(dest => dest.ReportDescription, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.OriginApplicationUserUserName, opt => opt.MapFrom(src => src.Lesson.ApplicationUser.UserName))
                .ForMember(dest => dest.CreatedByUserName, opt => opt.MapFrom(src => src.Lesson.ApplicationUser.UserName))
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.Lesson.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Lesson.Description))
                .ForMember(dest => dest.Grade, opt => opt.MapFrom(src => src.Lesson.Grade))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Lesson.Category.Name))
                .ForMember(dest => dest.VideoLink, opt => opt.MapFrom(src => src.Lesson.Video.Link))
                .ForMember(dest => dest.VideoName, opt => opt.MapFrom(src => src.Lesson.Video.Name))
                .ForMember(dest => dest.ZippedFile, opt => opt.MapFrom(src => src.Lesson.Material.Link))
                .ForMember(dest => dest.ReportingUserId, opt => opt.MapFrom(src => src.ApplicationUserId))
                .ForMember(dest => dest.CreatedByUserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName));

            CreateMap<CommentReportModel, Report>()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ReportId))
                 .ForMember(dest => dest.CommentId, opt => opt.MapFrom(src => src.OriginId))
                 .ForMember(dest => dest.Subject, opt => opt.MapFrom(src => src.Subject))
                 .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.ReportDescription))
                 .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.ReportingUserId));

            CreateMap<Report, CommentReportModel>()
                  .ForMember(dest => dest.OriginId, opt => opt.MapFrom(src => src.CommentId))
                  .ForMember(dest => dest.ReportId, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dest => dest.Subject, opt => opt.MapFrom(src => src.Subject))
                  .ForMember(dest => dest.ReportDescription, opt => opt.MapFrom(src => src.Description))
                  .ForMember(dest => dest.OriginApplicationUserUserName, opt => opt.MapFrom(src => src.Comment.ApplicationUser.UserName))
                  .ForMember(dest => dest.CommentContent, opt => opt.MapFrom(src => src.Comment.Content))
                  .ForMember(dest => dest.ReportingUserId, opt => opt.MapFrom(src => src.ApplicationUserId))
                  .ForMember(dest => dest.CreatedByUserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName));

            CreateMap<Comment, CommentReportModel>()
               .ForMember(dest => dest.OriginId, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.CommentContent, opt => opt.MapFrom(src => src.Content))
               .ForMember(dest => dest.OriginApplicationUserUserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName))
               .ForMember(dest => dest.Subject, opt => opt.Ignore())
               .ForMember(dest => dest.ReportDescription, opt => opt.Ignore());

            CreateMap<Comment, CommentViewModel>()
                .ForMember(dest => dest.CommentId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.LessonId))
                .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.ApplicationUserId))
                .ForMember(dest => dest.CommentContent, opt => opt.MapFrom(src => src.Content))
                .ForMember(dest => dest.DateCreated, opt => opt.MapFrom(src => src.DateCreated))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName));

            CreateMap<CommentViewModel, Comment>()
                .ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.LessonId))
                .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.ApplicationUserId))
                .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.CommentContent));

            CreateMap<Comment, CommentMultiModel>()
                .ForMember(dest => dest.CommentId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.ApplicationUserId))
                .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
                .ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.LessonId))
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.Lesson.Name))
                .ForMember(dest => dest.LessonVideoLink, opt => opt.MapFrom(src => src.Lesson.Video.Link))
                .ForMember(dest => dest.LessonVideoName, opt => opt.MapFrom(src => src.Lesson.Video.Name))
                .ForMember(dest => dest.LessonVideoContentType, opt => opt.MapFrom(src => src.Lesson.Video.ContentType))
                .ForMember(dest => dest.LessonZippedFileLink, opt => opt.MapFrom(src => src.Lesson.Material.Link))
                .ForMember(dest => dest.LessonCreatedByUsername, opt => opt.MapFrom(src => src.Lesson.ApplicationUser.UserName))
                .ForMember(dest => dest.LessonGrade, opt => opt.MapFrom(src => src.Lesson.Grade))
                .ForMember(dest => dest.LessonDescription, opt => opt.MapFrom(src => src.Lesson.Description))
                .ForMember(dest => dest.LessonCategoryName, opt => opt.MapFrom(src => src.Lesson.Category.Name));

            CreateMap<CommentMultiModel, Comment>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CommentId))
                .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
                .ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.LessonId))
                .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.ApplicationUserId));

            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryViewModel, Category>();
        }
    }
}
