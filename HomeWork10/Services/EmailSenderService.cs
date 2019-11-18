using HomeWork10.DTOs;
using HomeWork10.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        public Task SendEmail(EmailMessageDTO emailMessage)
        {
            SmtpClient _smtp = new SmtpClient("smtp.yandex.ru", 25);
            _smtp.Credentials = new NetworkCredential("shipa.danilov@yandex.kz", "5343454karp99");
            _smtp.EnableSsl = true;
            MailMessage _mail = new MailMessage();
            _mail.From = new MailAddress("shipa.danilov@yandex.kz");
            _mail.To.Add(new MailAddress(emailMessage.To));
            _mail.SubjectEncoding = Encoding.UTF8;
            _mail.BodyEncoding = Encoding.UTF8;
            _mail.Subject = emailMessage.Title;
            _mail.Body = emailMessage.Text;
            return _smtp.SendMailAsync(_mail);

        }
    }
}
