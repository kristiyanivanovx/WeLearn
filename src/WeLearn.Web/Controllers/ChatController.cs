using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Data.Models.ChatApp;
using WeLearn.Services.Interfaces;
using WeLearn.Web.ChatApp;
using WeLearn.Web.Infrastructure;

namespace WeLearn.Web.Controllers
{
	[Authorize]
	public class ChatController : BaseController
	{
		private readonly IHubContext<ChatHub> chatHub;
		private readonly IUsersService usersService;
        private readonly IChatService chatService;

        public ChatController(
			IHubContext<ChatHub> chatHub,
			IUsersService usersService,
			IChatService chatService)
		{
			this.chatHub = chatHub;
			this.usersService = usersService;
            this.chatService = chatService;
        }

		public IActionResult Index()
		{
			IEnumerable<Chat> chats = this.chatService.GetChats(GetUserId());
			return View(chats);
		}

		public IActionResult Joined(int id)
		{
			Chat chat = this.chatService.GetChat(id);
			return View(chat);
		}

		public async Task<IActionResult> SendMessage(int roomId, string message)
		{
			Message messageModel = await this.chatService.CreateMessageAsync(roomId, message, GetUserName());

			await chatHub.Clients.Group(roomId.ToString())
				.SendAsync("ReceiveMessage", new
				{
					Text = messageModel.Text,
					Name = messageModel.Name,
					DateCreated = messageModel.DateCreated.ToString("dd/MM/yyyy @ hh:mm:ss")
				});

			return Ok();
		}

		public async Task<IActionResult> Find()
		{
			IEnumerable<ApplicationUser> users = await this.usersService.GetUsersAsync(GetUserId());
			return View(users);
		}
	
		public async Task<IActionResult> CreateRoom(string name)
		{
			if (name == null)
			{
				return RedirectToAction(nameof(Index));
			}

			await this.chatService.CreateRoomAsync(name, GetUserId());
			return RedirectToAction(nameof(Index));
		}

		[HttpGet]
		public async Task<IActionResult> JoinRoom(int id)
		{
			await this.chatService.JoinRoomAsync(id, GetUserId());
			return RedirectToAction(nameof(Joined), new { id });
		}
	}
}
