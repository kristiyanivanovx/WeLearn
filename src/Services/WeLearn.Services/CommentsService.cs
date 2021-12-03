using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Data.Repositories;
using WeLearn.Services.Interfaces;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Admin.Comment;
using WeLearn.Web.ViewModels.Comment;

namespace WeLearn.Services
{
    public class CommentsService : ICommentsService
    {
        private readonly CommentRepository commentRepository;

        public CommentsService(CommentRepository commentRepository)
            => this.commentRepository = commentRepository;

        public async Task CreateCommentAsync(CommentInputModel commentInputModel)
        {
            Comment comment = new Comment
            {
                Content = commentInputModel.Content,
                ApplicationUserId = commentInputModel.ApplicationUserId,
                LessonId = commentInputModel.LessonId,
            };

            await this.commentRepository.AddAsync(comment);
            await this.commentRepository.SaveChangesAsync();
        }

        public async Task EditCommentAsync(CommentEditModel commentEditModel)
        {
            Comment entity = this.commentRepository.All().FirstOrDefault(x => x.Id == commentEditModel.Id);
            if (entity != null)
            {
                entity.Content = commentEditModel.Content ?? entity.Content;
            }

            await this.commentRepository.SaveChangesAsync();
        }

        public async Task EditCommentByAdminAsync(AdminCommentEditModel commentEditModel)
        {
            Comment comment = this.commentRepository
                .All()
                .FirstOrDefault(x => x.Id == commentEditModel.Id);

            if (comment != null)
            {
                comment.Content = commentEditModel.Content ?? comment.Content;

                if (comment.IsDeleted)
                {
                    this.commentRepository.Delete(comment);
                }
                else
                {
                    this.commentRepository.Undelete(comment);
                }
            }

            await this.commentRepository.SaveChangesAsync();
        }

        public async Task SoftDeleteCommentByIdAsync(int commentId)
        {
            Comment comment = this.commentRepository.AllWithDeleted().FirstOrDefault(x => x.Id == commentId);
            if (comment != null)
            {
                this.commentRepository.Delete(comment);
            }

            await this.commentRepository.SaveChangesAsync();
        }

        public async Task HardDeleteCommentByIdAsync(int commentId)
        {
            Comment comment = this.commentRepository.AllWithDeleted().FirstOrDefault(x => x.Id == commentId);
            if (comment != null)
            {
                this.commentRepository.HardDelete(comment);
            }

            await this.commentRepository.SaveChangesAsync();
        }

        public async Task<T> GetCommentByIdAsync<T>(int id)
            => await this.commentRepository.All()
                .Where(x => x.Id == id)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.ApplicationUser)
                .Include(x => x.ApplicationUser)
                .To<T>()
                .FirstOrDefaultAsync();

        public async Task<IEnumerable<CommentByMeModel>> GetCommentsMadeByMeAsync(string userId)
            => await this.commentRepository.All()
                .Where(x => x.ApplicationUserId == userId)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.ApplicationUser)
                .To<CommentByMeModel>()
                .ToListAsync();

        public async Task<IEnumerable<AdminCommentViewModel>> GetAllCommentsAsync(string searchString = null)
        {
            IQueryable<Comment> allComments = this.commentRepository.AllWithDeleted();
            if (!string.IsNullOrEmpty(searchString))
            {
                allComments = allComments.Where(x => x.Content.ToLower().Contains(searchString.ToLower()));
            }

            var comments = await allComments
                .Include(x => x.ApplicationUser)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.ApplicationUser)
                .OrderByDescending(x => x.CreatedOn)
                .To<AdminCommentViewModel>()
                .ToListAsync();

            return comments;
        }
    }
}
