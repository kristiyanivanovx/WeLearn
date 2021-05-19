using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.Data.Models.ChatApp;

namespace WeLearn.Services.CronJobs
{
    public class DbCleanupJob
    {
        private readonly ApplicationDbContext context;

        public DbCleanupJob(ApplicationDbContext context)
            => this.context = context;

        public async Task WorkAsync()
        {
            DbSet<Message> messages = this.context.Messages;
            this.context.Messages.RemoveRange(messages);
            await this.context.SaveChangesAsync();

            DbSet<ChatApplicationUser> chatApplicationUsers = this.context.ChatApplicationUsers;
            this.context.ChatApplicationUsers.RemoveRange(chatApplicationUsers);
            await this.context.SaveChangesAsync();

            DbSet<Chat> chats = this.context.Chats;
            this.context.Chats.RemoveRange(chats);
            await this.context.SaveChangesAsync();
        }
    }
}
