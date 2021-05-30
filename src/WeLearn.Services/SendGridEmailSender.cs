using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SendGrid;
using SendGrid.Helpers.Mail;
using WeLearn.Services.Interfaces;

namespace WeLearn.Services
{
	public class SendGridEmailSender : IEmailSender
	{
		private readonly SendGridClient client;

		public SendGridEmailSender(string apiKey)
		{
			this.client = new SendGridClient(apiKey);
		}

		public async Task SendEmailAsync(string from, string fromName, string to, string subject, string content)
		{
			if (string.IsNullOrWhiteSpace(subject) && string.IsNullOrWhiteSpace(content))
			{
				throw new ArgumentException("Subject and message should be provided.");
			}

			EmailAddress fromAddress = new EmailAddress(from, fromName);
			EmailAddress toAddress = new EmailAddress(to);
			SendGridMessage message = MailHelper.CreateSingleEmail(fromAddress, toAddress, subject, null, content);

			try
			{
				Response response = await this.client.SendEmailAsync(message);
				Console.WriteLine(response.StatusCode);
				Console.WriteLine(await response.Body.ReadAsStringAsync());
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
	}
}

  
