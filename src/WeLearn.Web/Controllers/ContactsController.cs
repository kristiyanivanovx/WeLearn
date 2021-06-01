using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;
using WeLearn.Services.Interfaces;
using WeLearn.ViewModels;

namespace WeLearn.Web.Controllers
{
	public class ContactsController : BaseController
	{
		private readonly IEmailSender emailSender;

		public ContactsController(IEmailSender emailSender)
			=> this.emailSender = emailSender;

		public IActionResult Sent()
			=> View();
		public IActionResult Index()
			=> View();

		[HttpPost]
		public async Task<IActionResult> Index(ContactsInputModel model)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}

			await this.emailSender.SendEmailAsync(model.FromEmail, model.FromName, "welearnbg@gmail.com", model.Subject, model.Content);
			return View(nameof(Sent));
		}
	}
}
