using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.Infrastructure.ViewModels;
using WeLearn.Services.Interfaces;

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

        public async Task<IEnumerable<CommentViewModel>> GenerateCommentViewModelsAsync(int lessonId)
        {
            var comments = await context.Comments
                .Where(x => x.Lesson.Id == lessonId && !x.IsDeleted)
                .Include(x => x.ApplicationUser)
                .OrderByDescending(x => x.DateCreated)
                .ToArrayAsync();

            var commentViewModels = mapper.Map<CommentViewModel[]>(comments);
            return commentViewModels;
        }

        public LessonsNavigationDropdownModel GenerateDropdownModel()
            => new LessonsNavigationDropdownModel
                {
                    Categories = context.Categories,
                    Lessons = context.Lessons
                };

        public async Task<int> GetUsersCountAsync()
            => await context.Users.CountAsync();
    }
}
