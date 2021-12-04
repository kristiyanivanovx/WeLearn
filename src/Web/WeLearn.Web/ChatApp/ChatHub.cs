using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace WeLearn.Web.ChatApp
{
    public class ChatHub : Hub
    {
        [HttpPost]
        public Task JoinRoom(string roomId) => Groups.AddToGroupAsync(GetConnectionId(), roomId);

        [HttpPost]
        public Task LeaveRoom(string roomId) => Groups.RemoveFromGroupAsync(GetConnectionId(), roomId);

        private string GetConnectionId() => Context.ConnectionId;
    }
}
