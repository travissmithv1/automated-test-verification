using System.Net.Mail;
using Xunit;
using OrderSystem;

namespace OrderSystemTests;

public class EmailBuilderTests
{
    [Fact]
    public void Build_IncludesWarehouseOperatorEmailAddress()
    {
        var email = EmailBuilder.Build(0);

        Assert.Single(email.To);
        Assert.Contains(new MailAddress("warehouseoperator@company.com"), email.To);
    }
    
    [Fact]
    public void Build_IncludesQuantityInTheSubject()
    {
        const int orderQuantity = 10;
        var email = EmailBuilder.Build(orderQuantity);

        Assert.Equal("10", email.Subject);
    }
    
    [Fact]
    public void Build_IncludesWarehouseManagerEmailAddress_WhenOrderQuantityIs201()
    {
        const int orderQuantity = 201;
        var email = EmailBuilder.Build(orderQuantity);
        
        Assert.Contains(new MailAddress("warehousemanager@company.com"), email.To);
    }
}