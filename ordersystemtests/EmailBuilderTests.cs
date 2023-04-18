using System.Collections.Generic;
using System.Linq;
using Xunit;
using ordersystem;

namespace ordersystemtests;

public class EmailBuilderTests
{
    [Fact]
    public void Build_IncludesWarehouseOperatorEmailAddress()
    {
        var email = EmailBuilder.Build(0);

        Assert.Equal("warehouseoperator@company.com", email.To.First());
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

        var expectedToAddresses = new List<string>
        {
            "warehouseoperator@company.com",
            "warehousemanager@company.com"
        };

        Assert.Equal(expectedToAddresses, email.To);
    }
}