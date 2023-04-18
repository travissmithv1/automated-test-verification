namespace ordersystem;
public class EmailBuilder
{
    public static Email Build(int orderQuantity)
    {
        var toAddresses = new List<string> { "warehouseoperator@company.com" };
        if (orderQuantity > 200)
        {
            toAddresses.Add("warehousemanager@company.com");
        }
        return new Email(toAddresses, orderQuantity.ToString());
    }
}
