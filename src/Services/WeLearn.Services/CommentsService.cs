using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Services.Interfaces;
using WeLearn.Web.ViewModels.Admin.Comment;
using WeLearn.Web.ViewModels.Comment;

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

        public async Task CreateCommentAsync(CommentInputModel commentInputModel)
        {
            Comment comment = this.mapper.Map<Comment>(commentInputModel);
            await this.context.Comments.AddAsync(comment);
            await this.context.SaveChangesAsync();
        }

        public async Task EditCommentAsync(CommentEditModel commentEditModel)
        {
            Comment entity = this.context.Comments.FirstOrDefault(x => x.Id == commentEditModel.Id);
            if (entity != null)
            {
                entity.Content = commentEditModel.Content ?? entity.Content;
            }

            await this.context.SaveChangesAsync();
        }

        public async Task EditCommentByAdminAsync(AdminCommentEditModel commentEditModel)
        {
            Comment entity = this.context.Comments.FirstOrDefault(x => x.Id == commentEditModel.Id);
            if (entity != null)
            {
                entity.Content = commentEditModel.Content ?? entity.Content;
                // entity.IsDeleted = commentEditModel.IsDeleted;
                // entity.DateCreated = commentEditModel.DateCreated;
            }

            await this.context.SaveChangesAsync();
        }

        public async Task SoftDeleteCommentByIdAsync(int commentId)
        {
            Comment comment = this.context.Comments.FirstOrDefault(x => x.Id == commentId);
            if (comment != null)
            {
                comment.IsDeleted = true;
            }

            await this.context.SaveChangesAsync();
        }

        public async Task HardDeleteCommentByIdAsync(int commentId)
        {
            Comment comment = this.context.Comments.FirstOrDefault(x => x.Id == commentId);
            if (comment != null)
            {
                this.context.Comments.Remove(comment);
            }

            await this.context.SaveChangesAsync();
        }

        public async Task<T> GetCommentByIdAsync<T>(int id)
        {
            Comment comment = await this.context.Comments
                .Where(x => x.Id == id)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.ApplicationUser)
                .Include(x => x.ApplicationUser)
                .FirstOrDefaultAsync();

            T commentMapped = this.mapper.Map<T>(comment);
            return commentMapped;
        }

        public async Task<IEnumerable<CommentByMeModel>> GetCommentsMadeByMeAsync(string userId)
        {
            List<Comment> commentsByMe = await this.context.Comments
                .Where(x => x.ApplicationUserId == userId && !x.IsDeleted)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.ApplicationUser)
                .ToListAsync();

            CommentByMeModel[] commentsByMeMapped = this.mapper.Map<CommentByMeModel[]>(commentsByMe);
            return commentsByMeMapped;
        }

        public async Task<IEnumerable<AdminCommentViewModel>> GetAllCommentsAsync(string searchString = null)
        {
            IQueryable<Comment> allComments = this.context.Comments;
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
                .Include(x => x.Lesson.ApplicationUser)
                .OrderByDescending(x => x.CreatedOn)
                .ToListAsync();

            AdminCommentViewModel[] allCommentsMapped = this.mapper.Map<AdminCommentViewModel[]>(allComments);
            return allCommentsMapped;
        }
    }
}
