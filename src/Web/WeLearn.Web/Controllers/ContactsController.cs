using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Threading.Tasks;
using WeLearn.Services.Interfaces;
using WeLearn.Web.ViewModels.Contacts;
using static WeLearn.Common.GlobalConstants;

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

			string message = BuildMessage(model);
			await this.emailSender.SendEmailAsync(ApplicationAdministratorEmail, ApplicationAdministratorEmail, model.Subject, message, false);
			return View(nameof(Sent));
		}

		private static string BuildMessage(ContactsInputModel model)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string message = stringBuilder
				.AppendLine("From Name: " + model.FromName)
				.AppendLine("From Email: " + model.FromEmail)
				.AppendLine("Content: ")
				.Append(model.Content)
				.ToString()
				.Trim();

			return message;
		}
	}
}
