using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.Data.Models.ChatApp;
using WeLearn.Services;
using WeLearn.Tests.HelperClasses;
using Xunit;

namespace WeLearn.Tests
{
	public class ChatServiceTests
	{
        [Fact]
        public async Task Should_Succeed_When_MessageIsCreated()
        {
            // arrange 
            var data = new List<Message>
            {
                new Message { Id = 1, Name = "Cdsa", Text = "123", DateCreated = DateTime.Now, ChatId = 1 },
                new Message { Id = 2, Name = "Cdsa2", Text = "1233", DateCreated = DateTime.Now, ChatId = 1  },
            }.AsQueryable();

            Mock<DbSet<Message>> mockSet = new Mock<DbSet<Message>>();

            mockSet.As<IAsyncEnumerable<Message>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Message>(data.GetEnumerator()));

            mockSet.As<IQueryable<Message>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Message>(data.Provider));

            mockSet.As<IQueryable<Message>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Message>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Message>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Messages).Returns(mockSet.Object);

            var service = new ChatService(mockContext.Object);

            // act
            await service.CreateMessageAsync(1, "asd", "123");

            // assert
            mockContext.Verify(x => x.SaveChangesAsync(new CancellationToken()), Times.Once());
        }

        [Fact]
        public async Task Should_Succeed_When_RoomIsCreated()
        {
            // arrange 
            var data = new List<Chat>
            {
                new Chat { Id = 1, Name = "Cdsa", DateCreated = DateTime.Now },
                new Chat { Id = 2, Name = "Cdsa2", DateCreated = DateTime.Now  },
            }.AsQueryable();

            Mock<DbSet<Chat>> mockSet = new Mock<DbSet<Chat>>();

            mockSet.As<IAsyncEnumerable<Chat>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Chat>(data.GetEnumerator()));

            mockSet.As<IQueryable<Chat>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Chat>(data.Provider));

            mockSet.As<IQueryable<Chat>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Chat>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Chat>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Chats).Returns(mockSet.Object);

            var service = new ChatService(mockContext.Object);

            // act
            await service.CreateRoomAsync("asd", "123");

            // assert
            mockContext.Verify(x => x.SaveChangesAsync(new CancellationToken()), Times.Once());
        }

        [Fact]
        public void Should_Succeed_When_ChatIsRetrieved()
        {
            // arrange 
            var data = new List<Chat>
            {
                new Chat { Id = 1, Name = "Cdsa", DateCreated = DateTime.Now },
                new Chat { Id = 2, Name = "Cdsa2", DateCreated = DateTime.Now  },
            }.AsQueryable();

            Mock<DbSet<Chat>> mockSet = new Mock<DbSet<Chat>>();

            mockSet.As<IAsyncEnumerable<Chat>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Chat>(data.GetEnumerator()));

            mockSet.As<IQueryable<Chat>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Chat>(data.Provider));

            mockSet.As<IQueryable<Chat>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Chat>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Chat>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Chats).Returns(mockSet.Object);

            var service = new ChatService(mockContext.Object);

            // act
            Chat chat = service.GetChat(2);

            // assert
            Assert.NotNull(chat);
        }

        [Fact]
        public async Task Should_Succeed_When_ChatsAreRetrievedByType()
        {
            // arrange 
            var data = new List<Chat>
            {
                new Chat { Id = 1, Name = "Cdsa",  DateCreated = DateTime.Now },
                new Chat { Id = 2, Name = "Cdsa2", DateCreated = DateTime.Now  },
            }.AsQueryable();

            Mock<DbSet<Chat>> mockSet = new Mock<DbSet<Chat>>();

            mockSet.As<IAsyncEnumerable<Chat>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Chat>(data.GetEnumerator()));

            mockSet.As<IQueryable<Chat>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Chat>(data.Provider));

            mockSet.As<IQueryable<Chat>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Chat>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Chat>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Chats).Returns(mockSet.Object);

            var service = new ChatService(mockContext.Object);

            // act
            var chats = await service.GetAllChats();

            // assert
            Assert.Equal(2, chats.Count());
        }
    }
}
