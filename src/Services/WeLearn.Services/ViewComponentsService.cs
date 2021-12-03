using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Services.Interfaces;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Category;
using WeLearn.Web.ViewModels.Comment;
using WeLearn.Web.ViewModels.Lesson;

namespace WeLearn.Services
{
    public class ViewComponentsService : IViewComponentsService
    {
        private readonly ApplicationDbContext context;

        public ViewComponentsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<CommentViewModel>> GetCommentsAsync(int lessonId)
            => await this.context.Comments
                .Where(x => x.Lesson.Id == lessonId && !x.IsDeleted)
                .Include(x => x.ApplicationUser)
                .OrderByDescending(x => x.CreatedOn)
                .To<CommentViewModel>()
                .ToArrayAsync();

        public LessonsNavigationDropdownModel GenerateDropdownModel()
            => new LessonsNavigationDropdownModel
                {
                    Categories = this.context.Categories.To<CategoryViewModel>().ToArray(),
                    Lessons = this.context.Lessons.To<LessonViewModel>().ToArray(),
                };

        public async Task<int> GetUsersCount()
            => await this.context.Users.CountAsync();
    }
}
