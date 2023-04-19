using System.Net.Mail;

namespace OrderSystem;

public interface IEmailService
{
    void Send(MailMessage mailMessage);
}

public class EmailService : IEmailService
{
    private readonly SmtpClient _smtpClient;

    public EmailService(SmtpClient smtpClient)
    {
        _smtpClient = smtpClient;
    }
    
    public void Send(MailMessage mailMessage)
    {
        _smtpClient.Send(mailMessage);
    }
}