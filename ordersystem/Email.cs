namespace ordersystem;

public class Email
{
    public List<string> To { get; }
    public string Subject { get; }

    public Email(List<string> toAddress, string subject){
        To = toAddress;
        Subject = subject;
    }
}
