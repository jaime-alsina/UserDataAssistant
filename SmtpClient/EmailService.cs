using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Email.Service
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendEmail(string message)
        {
            using (var client = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = _configuration["Email:Email"],
                    Password = _configuration["Email:Password"]
                };

                client.Credentials = credential;
                client.Host = _configuration["Email:Host"];
                client.Port = int.Parse(_configuration["Email:Port"]);

                bool.TryParse(_configuration["Email:EnableSsl"], out var enableSsl);

                client.EnableSsl = enableSsl;

                using (var emailMessage = new MailMessage())
                {
                    emailMessage.To.Add(new MailAddress(_configuration["Email:EmailTo"]));
                    emailMessage.From = new MailAddress(_configuration["Email:EmailFrom"]);
                    emailMessage.Subject = _configuration["Email:Subject"];
                    emailMessage.Body = message;
                    client.Send(emailMessage);
                }
            }
            await Task.CompletedTask;
        }
    }
}
