using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Services.Interfaces;
using WeLearn.ViewModels.Message;

namespace WeLearn.Web.Controllers
{
    public class MessageController : BaseController
    {
        private readonly IPrivateMessageService privateMessageService;
        private readonly IUsersService usersService;

        public MessageController(IPrivateMessageService privateMessageService, IUsersService usersService)
        {
            this.privateMessageService = privateMessageService;
            this.usersService = usersService;
        }

        [Authorize]
        public IActionResult To(string correspondent)
        {
            AllPrivateMessagesViewModel<PrivateMessageConversationViewModel> model 
                = this.privateMessageService.CreateConversationViewModel(correspondent, GetUserName(), GetUserId());

            return View(model);
        }

        [Authorize]
        public IActionResult Index()
        {
            AllPrivateMessagesViewModel<PrivateMessageIndexViewModel> model = this.privateMessageService.CreateIndexViewModel(GetUserName(), GetUserId());
            return View(model);
        }
        
        [Authorize]
        public IActionResult Create()
        {
            PrivateMessageInputModel model = new PrivateMessageInputModel();
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(PrivateMessageInputModel model, string correspondent = null)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ApplicationUser receiver = await this.usersService.GetUserByUsernameAsync(model.ReceiverUsername);
            if (receiver == null)
            {
                model.ReceiverUsernameErrorMessage = $"User {model.ReceiverUsername} doesn't exist.";
                return View(model);
            }

            await this.privateMessageService.CreatePrivateMessageAsync(model, GetUserId());

            model.ReceiverUsernameErrorMessage = null;
            return RedirectToAction(nameof(To), "message", new { correspondent = model.ReceiverUsername });
        }
    }
}
