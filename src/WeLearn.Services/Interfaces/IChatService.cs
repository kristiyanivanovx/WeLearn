using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeLearn.Data.Models.ChatApp;

namespace WeLearn.Services.Interfaces
{
    public interface IChatService
    {
        Chat GetChat(int id);

        IEnumerable<Chat> GetChats(string userId);

        Task CreateRoomAsync(string name, string userId);

        Task JoinRoomAsync(int chatId, string userId);

        Task<Message> CreateMessageAsync(int chatId, string message, string userName);
    }
}
