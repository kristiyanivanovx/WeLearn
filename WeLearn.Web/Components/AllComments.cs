using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using WeLearn.Data.Context;
using WeLearn.Infrastructure.ViewModels;
using WeLearn.Data.Models;

namespace WeLearn.Web.Components
{
    public class AllComments : ViewComponent
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public AllComments(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(int postId)
        {
            Comment[] comments = await context.Comments
                .Where(x => x.Post.PostId == postId)
                .Include(x => x.ApplicationUser)
                .OrderByDescending(x => x.DateCreated)
                .ToArrayAsync();

            CommentViewModel[] commentViewModels = mapper.Map<CommentViewModel[]>(comments);
            return View(commentViewModels);
        }
    }
}
