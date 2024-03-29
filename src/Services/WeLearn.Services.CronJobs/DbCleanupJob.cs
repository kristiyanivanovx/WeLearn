﻿using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data;
using WeLearn.Data.Models.ChatApp;

namespace WeLearn.Services.CronJobs
{
    public class DbCleanupJob
    {
        private readonly DatabaseContext context;

        public DbCleanupJob(DatabaseContext context)
            => this.context = context;

        public async Task WorkAsync()
        {
            int mainChatId = 1;

            // remove all messages
            DbSet<Message> messages = this.context.Messages;
            this.context.Messages.RemoveRange(messages);
            await this.context.SaveChangesAsync();

            // remove all chat users where the chat id is not 1
            var chatApplicationUsers = this.context.ChatUsers
                .Where(x => x.Chat.Id != mainChatId)
                .ToList();

            this.context.ChatUsers.RemoveRange(chatApplicationUsers);
            await this.context.SaveChangesAsync();

            // remove all chats where the chat id is not 1
            var chats = this.context.Chats
                .Where(x => x.Id != mainChatId)
                .ToList();

            this.context.Chats.RemoveRange(chats);
            await this.context.SaveChangesAsync();
        }
    }
}
