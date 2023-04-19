using System.Net.Mail;

namespace OrderSystem;
public static class EmailBuilder
{
    public static MailMessage Build(int orderQuantity)
    {
        var mailMessage = new MailMessage();
        mailMessage.To.Add("warehouseoperator@company.com");
        if (orderQuantity > 200)
        {
            mailMessage.To.Add("warehousemanager@company.com");
        }
        mailMessage.Subject = orderQuantity.ToString();
        return mailMessage;
    }
}
