using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.Data.Models.ChatApp;
using WeLearn.Services.Interfaces;

namespace WeLearn.Services
{
    public class ChatService : IChatService
    {
        private readonly ApplicationDbContext context;

        public ChatService(ApplicationDbContext context)
            => this.context = context;

        public async Task<Message> CreateMessageAsync(int chatId, string message, string userName)
        {
            Message messageModel = new Message
            {
                ChatId = chatId,
                Text = message,
                Name = userName,
                DateCreated = DateTime.UtcNow
            };

            this.context.Messages.Add(messageModel);
            await this.context.SaveChangesAsync();

            return messageModel;
        }

        public async Task CreateRoomAsync(string name, string userId)
        {
            Chat chat = new Chat
            {
                Name = name,
                DateCreated = DateTime.UtcNow,
            };

            chat.ChatApplicationUsers.Add(new ChatApplicationUser
            {
                ApplicationUserId = userId,
            });

            this.context.Chats.Add(chat);
            await this.context.SaveChangesAsync();
        }

        public Chat GetChat(int id)
            => this.context.Chats
                .Include(x => x.Messages)
                .FirstOrDefault(x => x.Id == id);

        public async Task<List<Chat>> GetAllChats()
            => await this.context.Chats
                .ToListAsync();

        public IEnumerable<Chat> GetChats(string userId)
            => this.context.Chats
                .Include(x => x.ChatApplicationUsers)
                .Where(x => !x.ChatApplicationUsers
                    .Any(y => y.ApplicationUserId == userId))
                .ToList();

        public async Task JoinRoomAsync(int chatId, string userId)
        {
            ChatApplicationUser chatUser = new ChatApplicationUser
            {
                ChatId = chatId,
                ApplicationUserId = userId,
            };

            this.context.ChatApplicationUsers.Add(chatUser);
            await this.context.SaveChangesAsync();
        }
    }
}
