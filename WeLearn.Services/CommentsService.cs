using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Data.Context;
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

        public async Task DeleteCommentByIdAsync(int id)
        {
            var comment = await context.Comments.FirstOrDefaultAsync(x => x.CommentId == id);
            comment.IsDeleted = true;
            comment.DateDeleted = DateTime.UtcNow;
            await context.SaveChangesAsync();
        }

        public async Task EditCommentAsync(CommentMultiModel commentEditModel)
        {
            var entity = context.Comments.FirstOrDefault(x => x.CommentId == commentEditModel.CommentId);
            entity.Content = commentEditModel.Content ?? entity.Content;
            await context.SaveChangesAsync();
        }

        public async Task<T> GetCommentByIdAsync<T>(int id)
        {
            var comment = await context.Comments
                .Where(x => x.CommentId == id)
                .Include(x => x.Post)
                .Include(x => x.Post.Category)
                .Include(x => x.Post.ApplicationUser)
                .FirstOrDefaultAsync();

            var commentMapped = mapper.Map<T>(comment);
            return commentMapped;
        }

        public async Task<IEnumerable<T>> UploadedByMeAsync<T>(string userId)
        {
            var commentsByMe = await context.Comments
                .Where(x => x.ApplicationUserId == userId)
                .Include(x => x.Post)
                .Include(x => x.Post.Video)
                .Include(x => x.Post.Material)
                .Include(x => x.Post.ApplicationUser)
                .ToListAsync();

            var commentsByMeMapped = mapper.Map<T[]>(commentsByMe);
            return commentsByMeMapped;
        }
    }
}
