using System;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data;
using WeLearn.Data.Models.ChatApp;
using WeLearn.Data.Repositories;
using WeLearn.Services;
using WeLearn.Services.Data;
using WeLearn.Tests.Mocks;
using Xunit;

namespace WeLearn.Tests
{
    public class ChatServiceTests
    {
        [Fact]
        public async Task Should_Succeed_When_MessageIsCreated()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var messageRepository = new EfRepository<Message>(dbInstance);
            var chatAppUserRepository = new EfRepository<ChatApplicationUser>(dbInstance);
            var chatRepository = new EfRepository<Chat>(dbInstance);
            var service = new ChatService(chatRepository, chatAppUserRepository, messageRepository);

            var message = "asd";
            var userName = "123";

            // act
            await service.CreateMessageAsync(1, message, userName);
            var createdMessage = messageRepository.All().Where(x => x.Text == message && x.Name == userName);

            // assert
            Assert.Single(messageRepository.All());
            Assert.NotNull(createdMessage);
        }

        [Fact]
        public async Task Should_Succeed_When_RoomIsCreated()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var messageRepository = new EfRepository<Message>(dbInstance);
            var chatAppUserRepository = new EfRepository<ChatApplicationUser>(dbInstance);
            var chatRepository = new EfRepository<Chat>(dbInstance);
            var service = new ChatService(chatRepository, chatAppUserRepository, messageRepository);

            var roomName = "Room 1";
            var userId = "123";

            // act
            await service.CreateRoomAsync(roomName, userId);

            var chats = await service.GetAllChatsAsync();
            var chat = chats.FirstOrDefault(x => x.Name == roomName);
            var userBelongsToChat = chat?.ChatApplicationUsers.Any(x => x.ApplicationUserId == userId);

            // assert
            Assert.NotNull(chat);
            Assert.True(userBelongsToChat);
        }

        [Fact]
        public async Task Should_Succeed_When_ChatIsRetrieved()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var messageRepository = new EfRepository<Message>(dbInstance);
            var chatAppUserRepository = new EfRepository<ChatApplicationUser>(dbInstance);
            var chatRepository = new EfRepository<Chat>(dbInstance);
            var service = new ChatService(chatRepository, chatAppUserRepository, messageRepository);

            var roomName = "Room 1";
            var userId = "123";

            // act
            await service.CreateRoomAsync(roomName, userId);
            var createdChats = await service.GetAllChatsAsync();
            var createdChat = createdChats.FirstOrDefault(x => x.Name == roomName);

            var chat = service.GetChat(createdChat!.Id);

            // assert
            Assert.NotNull(chat);
            Assert.Equal(roomName, chat.Name);
            Assert.Empty(chat.Messages);
        }

        [Fact]
        public async Task Should_Succeed_When_ChatsAreRetrievedByExcludingUserId()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var messageRepository = new EfRepository<Message>(dbInstance);
            var chatAppUserRepository = new EfRepository<ChatApplicationUser>(dbInstance);
            var chatRepository = new EfRepository<Chat>(dbInstance);
            var service = new ChatService(chatRepository, chatAppUserRepository, messageRepository);

            var roomName = "Room 1";
            var userId = "123";
            var userIdTwo = "2";

            // act
            await service.CreateRoomAsync(roomName, userId);
            var chat = service.GetChats(userIdTwo);

            // assert
            Assert.NotNull(chat);
        }

        [Fact]
        public async Task Should_Succeed_When_ChatIsJoined()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var messageRepository = new EfRepository<Message>(dbInstance);
            var chatAppUserRepository = new EfRepository<ChatApplicationUser>(dbInstance);
            var chatRepository = new EfRepository<Chat>(dbInstance);
            var service = new ChatService(chatRepository, chatAppUserRepository, messageRepository);

            var roomName = "Room 1";
            var userId = "123";

            var userIdTwo = "2";

            // act
            await service.CreateRoomAsync(roomName, userId);
            var chat = service.GetChats(userIdTwo).FirstOrDefault(x => x.Name == roomName);

            await service.JoinRoomAsync(chat!.Id, userIdTwo);

            var userHasJoined = chatAppUserRepository
                .All()
                .Any(x => x.ApplicationUserId == userIdTwo && x.ChatId == chat.Id);

            // assert
            Assert.True(userHasJoined);
        }
    }
}
