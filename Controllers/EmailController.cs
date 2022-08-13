using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using SendEmailTest.Models;
using SendEmailTest.Services;

namespace SendEmailTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        
        [HttpPost]
        public IActionResult SendEmail([FromBody] Email emailData)
        {
            bool res = _emailService.SendEmail(emailData);

            return res ? Ok() : BadRequest();
        }
    }
}
