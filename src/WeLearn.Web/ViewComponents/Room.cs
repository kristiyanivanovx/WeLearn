using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Data.Models.ChatApp;
using WeLearn.Services.Interfaces;

namespace WeLearn.Web.ViewComponents
{
    public class Room : ViewComponent
    {
        private readonly IChatService chatService;

        public Room(IChatService chatService)
            => this.chatService = chatService;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Chat> chats = await this.chatService.GetAllChats();
            return View(chats);
        }
    }
}
