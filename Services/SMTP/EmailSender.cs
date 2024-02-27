using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Options;

namespace OtpTaskFinal.Services.SMTP;

public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string message)
    {
        SmtpClient client = new SmtpClient
        {
            Host = "smtp-relay.sendinblue.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            Credentials = new NetworkCredential("mostafa2gebril@gmail.com", "rsunafjoduxeeumm ")
        };
        return client.SendMailAsync("mostafa2gebril@gmail.com", email, subject, message);
    }
}