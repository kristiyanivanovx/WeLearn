using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeLearn.Services.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string fromEmail, string toEmail, string subject, string content, bool isContentHtml);
    }
}
