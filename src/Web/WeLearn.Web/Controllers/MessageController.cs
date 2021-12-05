using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Data.Models;
using WeLearn.Services.Interfaces;
using WeLearn.Web.ViewModels.Message;

namespace WeLearn.Web.Controllers
{
    public class MessageController : BaseController
    {
        private readonly IPrivateMessageService privateMessageService;
        private readonly IUsersService usersService;

        public MessageController(IPrivateMessageService privateMessageService, IUsersService usersService)
        {
            this.privateMessageService = privateMessageService;
            this.usersService = usersService;
        }

        [Authorize]
        public IActionResult To(string correspondent)
        {
            AllPrivateMessagesViewModel<PrivateMessageConversationViewModel> model
                = this.privateMessageService.CreateConversationViewModel(correspondent, this.GetUserName(), this.GetUserId());

            return this.View(model);
        }

        [Authorize]
        public IActionResult Index()
        {
            AllPrivateMessagesViewModel<PrivateMessageIndexViewModel> model = this.privateMessageService.CreateIndexViewModel(this.GetUserName(), this.GetUserId());
            return this.View(model);
        }

        [Authorize]
        public IActionResult Create()
        {
            PrivateMessageInputModel model = new PrivateMessageInputModel();
            return this.View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(PrivateMessageInputModel model, string correspondent = null)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            ApplicationUser receiver = await this.usersService.GetUserByUsernameAsync(model.ReceiverUsername);
            if (receiver == null)
            {
                model.ReceiverUsernameErrorMessage = $"User {model.ReceiverUsername} doesn't exist.";
                return this.View(model);
            }

            await this.privateMessageService.CreatePrivateMessageAsync(model, GetUserId());

            model.ReceiverUsernameErrorMessage = null;
            return this.RedirectToAction(nameof(this.To), "message", new { correspondent = model.ReceiverUsername });
        }
    }
}
