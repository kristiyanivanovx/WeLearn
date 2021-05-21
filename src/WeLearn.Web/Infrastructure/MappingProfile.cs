using AutoMapper;
using WeLearn.Data.Models;
using WeLearn.ViewModels;

namespace WeLearn.Web.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LessonInputModel, Lesson>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.LessonName))
                .ForMember(dest => dest.ApplicationUserId, opt => opt.Ignore())
                .ForMember(dest => dest.VideoId, opt => opt.Ignore())
                .ForMember(dest => dest.Video, opt => opt.Ignore())
                .ForMember(dest => dest.MaterialId, opt => opt.Ignore())
                .ForMember(dest => dest.Material, opt => opt.Ignore());

            CreateMap<Lesson, LessonEditModel>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.ApplicationUserId))
                .ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.OldVideoLink, opt => opt.MapFrom(src => src.Video.Link))
                .ForMember(dest => dest.OldFilesLink, opt => opt.MapFrom(src => src.Material.Link))
                .ForMember(dest => dest.Video, opt => opt.Ignore())
                .ForMember(dest => dest.Files, opt => opt.Ignore());

            CreateMap<LessonEditModel, Lesson>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.LessonId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.LessonName));

            CreateMap<Lesson, LessonViewModel>()
                .ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.Name));

            CreateMap<LessonViewModel, Lesson>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.LessonId));

            CreateMap<Lesson, LessonReportModel>()
                .ForMember(dest => dest.OriginId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.LessonGrade, opt => opt.MapFrom(src => src.Grade))
                .ForMember(dest => dest.LessonCategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.LessonDateCreated, opt => opt.MapFrom(src => src.DateCreated))
                .ForMember(dest => dest.LessonVideoLink, opt => opt.MapFrom(src => src.Video.Link))
                .ForMember(dest => dest.LessonVideoName, opt => opt.MapFrom(src => src.Video.Name))
                .ForMember(dest => dest.OriginApplicationUserUserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName))
                .ForMember(dest => dest.Subject, opt => opt.Ignore())
                .ForMember(dest => dest.ReportDescription, opt => opt.Ignore());

            CreateMap<LessonReportModel, Report>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ReportId))
                .ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.OriginId))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.ReportDescription))
                .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.ReportingUserId));

            CreateMap<Report, LessonReportModel>()
                .ForMember(dest => dest.OriginId, opt => opt.MapFrom(src => src.LessonId))
                .ForMember(dest => dest.ReportId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ReportDescription, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.OriginApplicationUserUserName, opt => opt.MapFrom(src => src.Lesson.ApplicationUser.UserName))
                .ForMember(dest => dest.ReportingUserId, opt => opt.MapFrom(src => src.ApplicationUserId))
                .ForMember(dest => dest.CreatedByUserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName));

            CreateMap<CommentReportModel, Report>()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ReportId))
                 .ForMember(dest => dest.CommentId, opt => opt.MapFrom(src => src.OriginId))
                 .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.ReportDescription))
                 .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.ReportingUserId));

            CreateMap<Report, CommentReportModel>()
                  .ForMember(dest => dest.OriginId, opt => opt.MapFrom(src => src.CommentId))
                  .ForMember(dest => dest.ReportId, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dest => dest.ReportDescription, opt => opt.MapFrom(src => src.Description))
                  .ForMember(dest => dest.OriginApplicationUserUserName, opt => opt.MapFrom(src => src.Comment.ApplicationUser.UserName))
                  .ForMember(dest => dest.ReportingUserId, opt => opt.MapFrom(src => src.ApplicationUserId))
                  .ForMember(dest => dest.CreatedByUserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName));

            CreateMap<Comment, CommentReportModel>()
               .ForMember(dest => dest.OriginId, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.CommentContent, opt => opt.MapFrom(src => src.Content))
               .ForMember(dest => dest.CommentDateCreated, opt => opt.MapFrom(src => src.DateCreated))
               .ForMember(dest => dest.OriginApplicationUserUserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName))
               .ForMember(dest => dest.Subject, opt => opt.Ignore())
               .ForMember(dest => dest.ReportDescription, opt => opt.Ignore());

            CreateMap<Comment, CommentViewModel>()
                .ForMember(dest => dest.CommentId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CommentContent, opt => opt.MapFrom(src => src.Content))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName));

            CreateMap<CommentViewModel, Comment>()
                .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.CommentContent));

            CreateMap<Comment, CommentMultiModel>()
                .ForMember(dest => dest.CommentId, opt => opt.MapFrom(src => src.Id));

            CreateMap<CommentMultiModel, Comment>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CommentId));

            CreateMap<Comment, AdministrationCommentModel>()
                .ForMember(dest => dest.CommentId, opt => opt.MapFrom(src => src.Id));

            CreateMap<Category, CategoryViewModel>()
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.Id));

            CreateMap<CategoryViewModel, Category>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CategoryId));

            CreateMap<Report, AdministrationReportModel>();

            CreateMap<AdministrationReportModel, Report>();

            CreateMap<Lesson, AdministrationLessonModel>()
                .ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.ApplicationUserId))
                .ForMember(dest => dest.CreatedByEmail, opt => opt.MapFrom(src => src.ApplicationUser.Email))
                .ForMember(dest => dest.ApplicationUserUserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName));

            CreateMap<AdministrationLessonModel, Lesson>();
        }
    }
}
