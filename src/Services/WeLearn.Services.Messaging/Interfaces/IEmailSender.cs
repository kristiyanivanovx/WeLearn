using System.Threading.Tasks;

namespace WeLearn.Services.Messaging.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string fromEmail, string toEmail, string subject, string content, bool isContentHtml);
    }
}
