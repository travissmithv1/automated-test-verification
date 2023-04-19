using System.Net.Mail;

namespace OrderSystem;

public interface IEmailService
{
    void Send(MailMessage mailMessage);
}

public class EmailService : IEmailService
{
    private readonly SmtpClient _smtpClient;
    
    public EmailService()
    {
        _smtpClient = new SmtpClient("emailserver.com");
    }
    
    public void Send(MailMessage mailMessage)
    {
        _smtpClient.Send(mailMessage);
    }
}