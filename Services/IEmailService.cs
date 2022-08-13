using SendEmailTest.Models;

namespace SendEmailTest.Services
{
    public interface IEmailService
    {
        public bool SendEmail(Email emailData);
    }
}
