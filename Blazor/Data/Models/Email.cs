namespace Blazor.Data.Models;

public class Email
{
    public String Sender { get; set; }
    public String Receiver { get; set; }
    public String Title { get; set; }
    public String Body { get; set; }
    public DateTime TimeStamp { get; set; }
    
    public Email(string sender, string receiver, string title, string body, DateTime timeStamp)
    {
        Sender = sender;
        Receiver = receiver;
        Title = title;
        Body = body;
        TimeStamp = timeStamp;
    }
}