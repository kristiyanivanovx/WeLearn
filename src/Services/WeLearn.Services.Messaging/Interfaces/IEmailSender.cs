using System.Threading.Tasks;

using SendGrid;

namespace WeLearn.Services.Messaging.Interfaces
{
    public interface IEmailSender
    {
        Task<Response> SendEmailAsync(string fromEmail, string toEmail, string subject, string content, bool isContentHtml);
    }
}
