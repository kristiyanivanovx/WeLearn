using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace WeLearn.Web.ChatApp
{
    public class ChatHub : Hub
    {
        [HttpPost]
        public Task JoinRoom(string roomId) => this.Groups.AddToGroupAsync(this.GetConnectionId(), roomId);

        [HttpPost]
        public Task LeaveRoom(string roomId) => this.Groups.RemoveFromGroupAsync(this.GetConnectionId(), roomId);

        private string GetConnectionId() => this.Context.ConnectionId;
    }
}
