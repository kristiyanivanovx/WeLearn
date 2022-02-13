using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Data.Models.Identity;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Web.ViewModels.Like;

namespace WeLearn.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LikesController : ControllerBase
    {
        private readonly ILikesService likesService;
        private readonly UserManager<ApplicationUser> userManager;

        public LikesController(
            ILikesService likesService,
            UserManager<ApplicationUser> userManager)
        {
            this.likesService = likesService;
            this.userManager = userManager;
        }

        // POST /api/votes
        // Request body: {"postId":1}
        // Response body: {"likesCount":3}
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<LikeResponseModel>> ToggleLike(LikeInputModel model)
        {
            var userId = this.userManager.GetUserId(this.User);
            await this.likesService.ToggleAsync(model.LessonId, userId);

            var likesCount = this.likesService.GetCountByLessonId(model.LessonId);

            return new LikeResponseModel { LikesCount = likesCount };
        }
    }
}
