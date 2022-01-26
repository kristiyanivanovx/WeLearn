using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WeLearn.Data.Models.ChatApp;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Web.ChatApp;

namespace WeLearn.Web.Controllers
{
    [Authorize]
    public class ChatController : BaseController
    {
        private readonly IHubContext<ChatHub> chatHub;
        private readonly IChatService chatService;

        public ChatController(
            IHubContext<ChatHub> chatHub,
            IChatService chatService)
        {
            this.chatHub = chatHub;
            this.chatService = chatService;
        }

        public IActionResult Index()
            => this.RedirectToAction(nameof(this.Joined), new { id = 1 });

        public IActionResult Joined(int id)
        {
            Chat chat = this.chatService.GetChat(id);

            if (chat == null)
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            return this.View(chat);
        }

        public async Task<IActionResult> SendMessage(int roomId, string message)
        {
            if (message == null)
            {
                return this.BadRequest();
            }

            Message messageModel = await this.chatService
                .CreateMessageAsync(roomId, message, this.GetUserName());

            await this.chatHub.Clients.Group(roomId.ToString())
                .SendAsync("ReceiveMessage", new
                {
                    Text = messageModel.Text,
                    Name = messageModel.Name,
                    CreatedOn = messageModel.CreatedOn,
                });

            return this.Ok();
        }

        public async Task<IActionResult> CreateRoom(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrEmpty(name))
            {
                return this.RedirectToAction(nameof(this.Joined), new { id = 1 });
            }

            int id = await this.chatService.CreateRoomAsync(name, this.GetUserId());

            return this.RedirectToAction(nameof(this.Joined), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> JoinRoom(int id)
        {
            await this.chatService.JoinRoomAsync(id, this.GetUserId());
            return this.RedirectToAction(nameof(this.Joined), new { id });
        }
    }
}
