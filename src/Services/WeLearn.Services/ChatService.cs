using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.ChatApp;
using WeLearn.Data.Repositories;
using WeLearn.Services.Interfaces;

namespace WeLearn.Services
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
            };

            await this.messageRepository.AddAsync(messageModel);
            await this.messageRepository.SaveChangesAsync();

            return messageModel;
        }

        public async Task CreateRoomAsync(string name, string userId)
        {
            Chat chat = new Chat
            {
                Name = name,
                CreatedOn = DateTime.UtcNow,
            };

            chat.ChatApplicationUsers.Add(new ChatApplicationUser
            {
                ApplicationUserId = userId,
            });

            await this.chatRepository.AddAsync(chat);
            await this.chatRepository.SaveChangesAsync();
        }

        public Chat GetChat(int id)
            => this.chatRepository
                .All()
                .Include(x => x.Messages)
                .FirstOrDefault(x => x.Id == id);

        public async Task<List<Chat>> GetAllChats()
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