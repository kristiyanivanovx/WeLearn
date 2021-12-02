using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Services.Interfaces;
using WeLearn.Web.ViewModels.Category;
using WeLearn.Web.ViewModels.Comment;
using WeLearn.Web.ViewModels.Lesson;

namespace WeLearn.Services
{
    public class ViewComponentsService : IViewComponentsService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ViewComponentsService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<CommentViewModel>> GetCommentsAsync(int lessonId)
        {
            Comment[] comments = await this.context.Comments
                .Where(x => x.Lesson.Id == lessonId && !x.IsDeleted)
                .Include(x => x.ApplicationUser)
                .OrderByDescending(x => x.CreatedOn)
                .ToArrayAsync();

            // .То<CommentViewModel>()

            CommentViewModel[] commentViewModels = this.mapper.Map<CommentViewModel[]>(comments);
            return commentViewModels;
        }

        public LessonsNavigationDropdownModel GenerateDropdownModel()
            => new LessonsNavigationDropdownModel
                {
                    Categories = this.mapper.Map<CategoryViewModel[]>(this.context.Categories.ToArray()),
                    Lessons = this.mapper.Map<LessonViewModel[]>(this.context.Lessons.ToArray()),
                };

        public async Task<int> GetUsersCount()
            => await this.context.Users.CountAsync();
    }
}
