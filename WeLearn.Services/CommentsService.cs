using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Infrastructure.ViewModels;
using WeLearn.Services.Interfaces;

namespace WeLearn.Services
{
    public class CommentsService : ICommentsService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CommentsService(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task CreateCommentAsync(CommentViewModel commentViewModel)
        {
            var lesson = context.Lessons.FirstOrDefault(x => x.Id == commentViewModel.LessonId);
            var comment = new Comment { LessonId = lesson.Id, Content = commentViewModel.CommentContent, 
                                        DateCreated = DateTime.UtcNow, ApplicationUserId = commentViewModel.ApplicationUserId };
            await context.Comments.AddAsync(comment);
            await context.SaveChangesAsync();
        }

        public async Task DeleteCommentByIdAsync(int id)
        {
            var comment = await context.Comments.FirstOrDefaultAsync(x => x.Id == id);
            comment.IsDeleted = true;
            comment.DateDeleted = DateTime.UtcNow;
            await context.SaveChangesAsync();
        }

        public async Task EditCommentAsync(CommentMultiModel commentEditModel)
        {
            var entity = context.Comments.FirstOrDefault(x => x.Id == commentEditModel.CommentId);
            entity.Content = commentEditModel.Content ?? entity.Content;
            await context.SaveChangesAsync();
        }

        public async Task<T> GetCommentByIdAsync<T>(int id)
        {
            var comment = await context.Comments
                .Where(x => x.Id == id)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.ApplicationUser)
                .Include(x => x.ApplicationUser)
                .FirstOrDefaultAsync();

            var commentMapped = mapper.Map<T>(comment);
            return commentMapped;
        }

        public async Task<IEnumerable<CommentMultiModel>> MadeByMeToCommentMultiModelAsync(string userId)
        {
            var commentsByMe = await context.Comments
                .Where(x => x.ApplicationUserId == userId && !x.IsDeleted)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.ApplicationUser)
                .ToListAsync();

            var commentsByMeMapped = mapper.Map<CommentMultiModel[]>(commentsByMe);
            return commentsByMeMapped;
        }
    }
}
