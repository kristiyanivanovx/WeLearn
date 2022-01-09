using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.Identity;
using WeLearn.Data.Models.LessonModule;
using WeLearn.Data.Models.Shared;
using WeLearn.Services.Interfaces;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Category;
using WeLearn.Web.ViewModels.Comment;
using WeLearn.Web.ViewModels.Lesson;

namespace WeLearn.Services
{
    public class ViewComponentsService : IViewComponentsService
    {
        private readonly IRepository<Comment> commentRepository;
        private readonly IRepository<Category> categoryRepository;
        private readonly IRepository<Lesson> lessonRepository;
        private readonly IRepository<ApplicationUser> appUserRepository;

        public ViewComponentsService(
            IRepository<Comment> commentRepository,
            IRepository<Category> categoryRepository,
            IRepository<Lesson> lessonRepository,
            IRepository<ApplicationUser> appUserRepository)
        {
            this.commentRepository = commentRepository;
            this.categoryRepository = categoryRepository;
            this.lessonRepository = lessonRepository;
            this.appUserRepository = appUserRepository;
        }

        public async Task<IEnumerable<CommentViewModel>> GetCommentsAsync(int lessonId)
            => await this.commentRepository
                .All()
                .Where(x => x.Lesson.Id == lessonId && !x.IsDeleted)
                .Include(x => x.ApplicationUser)
                .OrderByDescending(x => x.CreatedOn)
                .To<CommentViewModel>()
                .ToArrayAsync();

        public LessonsNavigationDropdownModel GenerateDropdownModel()
            => new LessonsNavigationDropdownModel
                {
                    Categories = this.categoryRepository.All().To<CategoryViewModel>().ToArray(),
                    Lessons = this.lessonRepository.All().To<LessonViewModel>().ToArray(),
                };

        public async Task<int> GetUsersCount()
            => await this.appUserRepository.All().CountAsync();
    }
}
