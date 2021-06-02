using Microsoft.AspNetCore.Mvc;
using System.Text;
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

			StringBuilder stringBuilder = new StringBuilder();
			string message = stringBuilder
				.AppendLine("From Name: " + model.FromName)
				.AppendLine("From Email: " + model.FromEmail)
				.AppendLine("Content: ")
				.Append(model.Content)
				.ToString()
				.Trim();

			await this.emailSender.SendEmailAsync("welearnbg@gmail.com", model.Subject, message, false);
			return View(nameof(Sent));
		}
	}
}
