using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.ViewModels;
using WeLearn.Services.Interfaces;

namespace WeLearn.Services
{
    public class CommentsService : ICommentsService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CommentsService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task CreateCommentAsync(CommentViewModel commentViewModel)
        {
            Lesson lesson = context.Lessons.FirstOrDefault(x => x.Id == commentViewModel.LessonId);
            Comment comment = new Comment 
            { 
                LessonId = lesson.Id, 
                Content = commentViewModel.CommentContent, 
                DateCreated = DateTime.UtcNow, 
                ApplicationUserId = commentViewModel.ApplicationUserId 
            };

            await context.Comments.AddAsync(comment);
            await context.SaveChangesAsync();
        }

        public async Task EditCommentAsync(CommentMultiModel commentEditModel)
        {
            Comment entity = context.Comments.FirstOrDefault(x => x.Id == commentEditModel.CommentId);
            entity.Content = commentEditModel.Content ?? entity.Content;
            await context.SaveChangesAsync();
        }

        public async Task EditCommentByAdminAsync(AdministrationCommentModel commentEditModel)
        {
            Comment entity = context.Comments.FirstOrDefault(x => x.Id == commentEditModel.CommentId);
            entity.Content = commentEditModel.Content ?? entity.Content;
            entity.IsDeleted = commentEditModel.IsDeleted;
            entity.DateCreated = commentEditModel.DateCreated;
            await context.SaveChangesAsync();
        }

        public async Task SoftDeleteCommentByIdAsync(int commentId)
        {
            Comment comment = context.Comments.FirstOrDefault(x => x.Id == commentId);
            comment.IsDeleted = true;
            await context.SaveChangesAsync();
        }

        public async Task HardDeleteCommentByIdAsync(int commentId)
        {
            Comment comment = context.Comments.FirstOrDefault(x => x.Id == commentId);
            context.Comments.Remove(comment);
            await context.SaveChangesAsync();
        }

        public async Task<T> GetCommentByIdAsync<T>(int id)
        {
            Comment comment = await context.Comments
                .Where(x => x.Id == id)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.ApplicationUser)
                .Include(x => x.ApplicationUser)
                .FirstOrDefaultAsync();

            T commentMapped = mapper.Map<T>(comment);
            return commentMapped;
        }

        public async Task<IEnumerable<CommentMultiModel>> GetCommentsMadeByMeAsync(string userId)
        {
            List<Comment> commentsByMe = await context.Comments
                .Where(x => x.ApplicationUserId == userId && !x.IsDeleted)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.ApplicationUser)
                .ToListAsync();

            CommentMultiModel[] commentsByMeMapped = mapper.Map<CommentMultiModel[]>(commentsByMe);
            return commentsByMeMapped;
        }

        public async Task<IEnumerable<AdministrationCommentModel>> GetAllComments(string searchString)
        {
            IQueryable<Comment> allComments = context.Comments;
                            
            if (!string.IsNullOrEmpty(searchString))
            {
                allComments = allComments.Where(x => x.Content.ToLower().Contains(searchString.ToLower()));
            }

            await allComments
                .Include(x => x.ApplicationUser)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.Video)
                .OrderByDescending(x => x.DateCreated)
                .ToListAsync();

            AdministrationCommentModel[] allCommentsMapped = mapper.Map<AdministrationCommentModel[]>(allComments);
            return allCommentsMapped;
        }
    }
}
