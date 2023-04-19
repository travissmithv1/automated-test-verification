namespace OrderSystem;

public class Order
{
    private int Quantity { get; }
    private IEmailService EmailService { get; }

    public Order(IEmailService emailService, int quantity)
    {
        EmailService = emailService;
        Quantity = quantity;
    }

    public int Submit()
    {
        // Order is submitted to database; a unique order number is assigned
        var newOrderNumber = 1;
        EmailService.Send(EmailBuilder.Build(Quantity));
        return newOrderNumber;
    }
}