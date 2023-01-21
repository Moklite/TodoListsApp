using EmailService.Model;

namespace EmailService
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
