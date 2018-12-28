using System.Threading.Tasks;

namespace DisruptionWorks.Email.Service
{
    public interface IEmailService
    {
        Task SendEmail(string message);
    }
}
