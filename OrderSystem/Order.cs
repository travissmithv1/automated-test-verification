using System.Net.Mail;

namespace OrderSystem;

public class Order
{
    private int Quantity { get; }
    private readonly IEmailService _emailService;

    public Order(IEmailService emailService, int quantity)
    {
        _emailService = emailService;
        Quantity = quantity;
    }

    public int Submit()
    {
        // Order is submitted to database; a unique order number is assigned
        var newOrderNumber = 1;
        _emailService.Send(EmailBuilder.Build(Quantity));
        return newOrderNumber;
    }
}