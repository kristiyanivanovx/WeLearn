using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using SendGrid;
using WeLearn.Services.Messaging.Interfaces;

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
            => this.View();

        public IActionResult Index()
            => this.View();

        [HttpPost]
        public async Task<IActionResult> Index(ContactsInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            string message = BuildMessage(model);

            Response result = await this.emailSender.SendEmailAsync(
                SystemHeadAdministratorEmail,
                SystemHeadAdministratorEmail,
                model.Subject,
                message,
                false);

            var responseModel = new ContactsResponseModel
            {
                StatusCode = result.StatusCode,
            };

            return this.View(nameof(this.Sent), responseModel);
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
