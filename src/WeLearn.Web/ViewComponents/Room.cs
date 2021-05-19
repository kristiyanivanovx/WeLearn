using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.Data.Models.ChatApp;
using WeLearn.Web.Infrastructure;

namespace WeLearn.Web.ViewComponents
{
    public class Room : ViewComponent
    {
        private readonly ApplicationDbContext context;

        //service
        public Room(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Chat> chats = await this.context.Chats
                .Where(x => x.Type == ChatType.Room)
                .ToListAsync();

            return View(chats);
        }
    }
}
