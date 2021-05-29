using AutoMapper;
using System;
using WeLearn.Data.Models;
using WeLearn.ViewModels.Admin;
using WeLearn.ViewModels.Admin.Comment;
using WeLearn.ViewModels.Admin.Lesson;
using WeLearn.ViewModels.Admin.Report;
using WeLearn.ViewModels.Category;
using WeLearn.ViewModels.Comment;
using WeLearn.ViewModels.Lesson;
using WeLearn.ViewModels.Report;
using WeLearn.ViewModels.Report.Comment;
using WeLearn.ViewModels.Report.Lesson;

namespace WeLearn.Web.Infrastructure
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			// categories
			CreateMap<Category, CategoryViewModel>()
				.ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.Id));

			CreateMap<CategoryViewModel, Category>()
				.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CategoryId));

			// lessons
			CreateMap<LessonInputModel, Lesson>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.LessonName))
				.ForMember(dest => dest.ApplicationUserId, opt => opt.Ignore())
				.ForMember(dest => dest.Video, opt => opt.Ignore())
				.ForMember(dest => dest.VideoId, opt => opt.Ignore())
				.ForMember(dest => dest.Material, opt => opt.Ignore())
				.ForMember(dest => dest.MaterialId, opt => opt.Ignore());

			CreateMap<Lesson, LessonEditModel>()
				.ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.ApplicationUserId))
				.ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.OldVideoLink, opt => opt.MapFrom(src => src.Video.Link))
				.ForMember(dest => dest.OldFilesLink, opt => opt.MapFrom(src => src.Material.Link))
				.ForMember(dest => dest.Video, opt => opt.Ignore())
				.ForMember(dest => dest.Files, opt => opt.Ignore());

			CreateMap<LessonEditModel, Lesson>()
				.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.LessonId));

			CreateMap<Lesson, LessonViewModel>()
				.ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.Id));

			CreateMap<Lesson, LessonDeleteModel>()
			  .ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.Id));

			CreateMap<LessonViewModel, Lesson>()
				.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.LessonId));

			CreateMap<Report, LessonReportViewModel>()
				.ForMember(dest => dest.ReportId, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.ReportDescription, opt => opt.MapFrom(src => src.Description));

			CreateMap<Report, LessonReportDeleteModel>()
				.ForMember(dest => dest.ReportId, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.LessonId))
				.ForMember(dest => dest.ReportDescription, opt => opt.MapFrom(src => src.Description));

			CreateMap<Lesson, LessonReportInputModel>()
				.ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.LessonGrade, opt => opt.MapFrom(src => src.Grade))
				.ForMember(dest => dest.LessonVideoName, opt => opt.MapFrom(src => src.Video.Name))
				.ForMember(dest => dest.LessonVideoLink, opt => opt.MapFrom(src => src.Video.Link))
				.ForMember(dest => dest.LessonDescription, opt => opt.MapFrom(src => src.Description))
				.ForMember(dest => dest.LessonDateCreated, opt => opt.MapFrom(src => src.DateCreated))
				.ForMember(dest => dest.LessonCategoryName, opt => opt.MapFrom(src => src.Category.Name))
				.ForMember(dest => dest.LessonApplicationUserUserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName));

			CreateMap<LessonReportInputModel, Report>()
				.ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.ReportDescription));

			CreateMap<Report, LessonReportEditModel>()
				.ForMember(dest => dest.ReportId, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.LessonId))
				.ForMember(dest => dest.ReportDescription, opt => opt.MapFrom(src => src.Description));

			// lessons administration
			CreateMap<Lesson, AdminLessonViewModel>();

			CreateMap<Lesson, AdminLessonEditModel>();

			CreateMap<Lesson, AdminLessonDeleteModel>();

			// comments
			CreateMap<CommentInputModel, Comment>();

			CreateMap<Comment, CommentViewModel>();

			CreateMap<Comment, CommentDeleteModel>();

			CreateMap<Comment, CommentEditModel>();

			CreateMap<Comment, CommentByMeModel>();

			// comments reports
			CreateMap<Comment, CommentReportInputModel>()
				.ForMember(dest => dest.CommentId, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.CommentContent, opt => opt.MapFrom(src => src.Content))
				.ForMember(dest => dest.CommentDateCreated, opt => opt.MapFrom(src => src.DateCreated))
				.ForMember(dest => dest.CommentApplicationUserUserName, opt => opt.MapFrom(src => src.ApplicationUser.UserName));

			CreateMap<CommentReportInputModel, Report>()
				.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ReportId))
				.ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.ReportDescription));

			CreateMap<Report, CommentReportEditModel>()
				.ForMember(dest => dest.ReportId, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.ReportDescription, opt => opt.MapFrom(src => src.Description));

			CreateMap<Report, CommentReportDeleteModel>()
				.ForMember(dest => dest.ReportId, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.ReportDescription, opt => opt.MapFrom(src => src.Description));

			CreateMap<Report, CommentReportViewModel>()
				.ForMember(dest => dest.ReportId, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.ReportDescription, opt => opt.MapFrom(src => src.Description));

			// comments administration
			CreateMap<Comment, AdminCommentViewModel>()
				.ForMember(dest => dest.CommentId, opt => opt.MapFrom(src => src.Id));

			CreateMap<Comment, AdminCommentEditModel>()
				.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

			CreateMap<Comment, AdminCommentDeleteModel>();

			// reports administration
			CreateMap<Report, AdminReportViewModel>();

			CreateMap<Report, AdminReportEditModel>();

			CreateMap<Report, AdminReportDeleteModel>();
		}
	}
}
