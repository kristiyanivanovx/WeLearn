using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.LessonModule;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Admin.Comment;
using WeLearn.Web.ViewModels.Comment;

namespace WeLearn.Services.Data
{
    public class CommentsService : ICommentsService
    {
        private readonly IDeletableEntityRepository<Comment> commentRepository;

        public CommentsService(IDeletableEntityRepository<Comment> commentRepository)
            => this.commentRepository = commentRepository;

        public bool Contains(int id)
            => this.commentRepository
                .All()
                .Any(x => x.Id == id);

        public bool IsInLessonId(int commentId, int lessonId)
        {
            var commentLessonId = this.commentRepository
                .All()
                .Where(x => x.Id == commentId)
                .Select(x => x.LessonId)
                .FirstOrDefault();

            return commentLessonId == lessonId;
        }

        public int GetAllCommentsCount()
            => this.commentRepository
                .All()
                .Count();

        public async Task CreateCommentAsync(CommentInputModel model, int? parentId)
        {
            Comment comment = new Comment
            {
                Content = model.Content,
                UserId = model.UserId,
                LessonId = model.LessonId,
                ParentId = parentId,
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
                .AllWithDeleted()
                .FirstOrDefault(x => x.Id == commentEditModel.Id);

            if (comment != null)
            {
                comment.Content = commentEditModel.Content ?? comment.Content;

                if (commentEditModel.IsDeleted)
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

        public async Task<T> GetCommentByIdWithDeletedAsync<T>(int id)
            => await this.commentRepository.AllWithDeleted()
                .Where(x => x.Id == id)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.User)
                .Include(x => x.User)
                .To<T>()
                .FirstOrDefaultAsync();

        public async Task<IEnumerable<CommentByMeModel>> GetCommentsMadeByMeAsync(string userId)
            => await this.commentRepository.All()
                .Where(x => x.UserId == userId)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.User)
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
                .Include(x => x.User)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.User)
                .OrderByDescending(x => x.CreatedOn)
                .To<AdminCommentViewModel>()
                .ToListAsync();

            return comments;
        }
    }
}
