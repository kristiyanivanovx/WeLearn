using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.ChatApp;
using WeLearn.Services.Data.Interfaces;

namespace WeLearn.Services.Data
{
    public class ChatService : IChatService
    {
        private readonly IRepository<Chat> chatRepository;
        private readonly IRepository<ChatApplicationUser> chatAppUserRepository;
        private readonly IRepository<Message> messageRepository;

        public ChatService(
            IRepository<Chat> chatRepository,
            IRepository<ChatApplicationUser> chatAppUserRepository,
            IRepository<Message> messageRepository)
        {
            this.chatRepository = chatRepository;
            this.chatAppUserRepository = chatAppUserRepository;
            this.messageRepository = messageRepository;
        }

        public async Task<Message> CreateMessageAsync(int chatId, string message, string userName)
        {
            Message messageModel = new Message
            {
                ChatId = chatId,
                Text = message,
                Name = userName,
                CreatedOn = DateTime.UtcNow,
            };

            await this.messageRepository.AddAsync(messageModel);
            await this.messageRepository.SaveChangesAsync();

            return messageModel;
        }

        public async Task<int> CreateRoomAsync(string name, string userId)
        {
            Chat chat = new Chat
            {
                Name = name,
            };

            chat.ChatApplicationUsers.Add(new ChatApplicationUser
            {
                ApplicationUserId = userId,
            });

            await this.chatRepository.AddAsync(chat);
            await this.chatRepository.SaveChangesAsync();

            int chatId = this.chatRepository
                .All()
                .ToList()
                .First(c =>
                    c.Name == name &&
                    c.ChatApplicationUsers.Any(chatAppUser => chatAppUser.ApplicationUserId == userId))
                .Id;

            return chatId;
        }

        public Chat GetChat(int id)
            => this.chatRepository
                .All()
                .Include(x => x.Messages)
                .FirstOrDefault(x => x.Id == id);

        public async Task<List<Chat>> GetAllChatsAsync()
            => await this.chatRepository
                .All()
                .ToListAsync();

        public IEnumerable<Chat> GetChats(string userId)
            => this.chatRepository
                .All()
                .Include(x => x.ChatApplicationUsers)
                .Where(x => x.ChatApplicationUsers.All(y => y.ApplicationUserId != userId))
                .ToList();

        public async Task JoinRoomAsync(int chatId, string userId)
        {
            ChatApplicationUser chatUser = new ChatApplicationUser
            {
                ChatId = chatId,
                ApplicationUserId = userId,
            };

            await this.chatAppUserRepository.AddAsync(chatUser);
            await this.chatAppUserRepository.SaveChangesAsync();
        }
    }
}
