using System.Linq;
using System.Net.Mail;
using Moq;
using OrderSystem;
using Xunit;

namespace OrderSystemTests;

public class OrderTests
{
    [Fact]
    public void OrderNumberIsAssigned_WhenOrderIsSubmitted()
    {
        var mockSmtpClient = new Mock<IEmailService>();
        var order = new Order(mockSmtpClient.Object,1);
        var orderNumber = order.Submit();
        Assert.Equal(1, orderNumber);
    }

    [Fact]
    public void EmailIsSent_WhenOrderIsSubmitted()
    {
        var mockSmtpClient = new Mock<IEmailService>();

        var order = new Order(mockSmtpClient.Object, 1);
        order.Submit();

        mockSmtpClient.Verify(x => 
                x.Send(It.Is<MailMessage>(mm => 
                    mm.To.Single().ToString() == "warehouseoperator@company.com" && 
                    mm.Subject == "1")), 
            Times.Once);
    }
}