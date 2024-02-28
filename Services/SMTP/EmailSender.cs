using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Options;

namespace OtpTaskFinal.Services.SMTP;

public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string message)
    {
        var mail = "";
        var pw = "";
        SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587)
        {
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            Credentials = new NetworkCredential(mail,pw)
        };
        return client.SendMailAsync(new MailMessage(from: mail,
                                                     to: email,
                                                     subject,
                                                     message));
    }
}
