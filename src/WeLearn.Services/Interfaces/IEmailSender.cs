using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeLearn.Services.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string from, string fromName, string to, string subject, string content);
    }
}
