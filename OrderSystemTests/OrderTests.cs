using OrderSystem;
using Xunit;

namespace OrderSystemTests;

public class OrderTests
{
    [Fact]
    public void OrderNumberIsAssigned_WhenOrderIsSubmitted()
    {
        var order = new Order(25);
        var orderNumber = order.Submit();
        Assert.Equal(1, orderNumber);
    }
}