namespace OrderSystem;

public class Order
{
    private int Quantity { get; }

    public Order(int quantity)
    {
        Quantity = quantity;
    }

    public int Submit()
    {
        // Order is submitted to database; a unique order number is assigned
        var newOrderNumber = 1;
        return newOrderNumber;
    }
}