﻿using System;
using System.Threading.Tasks;

using SendGrid;
using SendGrid.Helpers.Mail;
using WeLearn.Services.Messaging.Interfaces;

namespace WeLearn.Services.Messaging
{
    public class SendGridEmailService : IEmailSender
    {
        private readonly SendGridClient client;

        public SendGridEmailService(string apiKey)
            => this.client = new SendGridClient(apiKey);

        public async Task<Response> SendEmailAsync(string from, string to, string subject, string content, bool isContentHtml)
        {
            if (string.IsNullOrWhiteSpace(subject) && string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentException("Subject and message should be provided.");
            }

            EmailAddress fromAddress = new EmailAddress(from);
            EmailAddress toAddress = new EmailAddress(to);
            SendGridMessage message;

            if (isContentHtml)
            {
                message = MailHelper.CreateSingleEmail(fromAddress, toAddress, subject, null, content);
            }
            else
            {
                message = MailHelper.CreateSingleEmail(fromAddress, toAddress, subject, content, null);
            }

            try
            {
                Response response = await this.client.SendEmailAsync(message);
                Console.WriteLine(response.StatusCode);
                Console.WriteLine(await response.Body.ReadAsStringAsync());

                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
