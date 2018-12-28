using System.Threading.Tasks;

namespace Email.Service
{
    public interface IEmailService
    {
        Task SendEmail(string message);
    }
}
