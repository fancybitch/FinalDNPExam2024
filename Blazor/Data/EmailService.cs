using System.Text.Json;
using Blazor.Data.Models;

namespace Blazor.Data;

public class EmailService: IEmailService
{
    public void SentEmail(Email email)
    {
        email.TimeStamp = DateTime.Now;
        email.Sender = "ola";
        emails.Add(email);
        string serialized =  JsonSerializer.Serialize(email);
        Console.WriteLine("Your email"+ serialized + "was sent");

    }
    
   static List<Email> emails = new List<Email>();
   
    public EmailService()
    {
        emails.Add(new Email("ola", "veronika", "hi", "body1", DateTime.Now));
        emails.Add(new Email("ola", "veronika", "hi", "body2", DateTime.Now));
        emails.Add(new Email("ola", "jagoda", "hello", "body3", DateTime.Now));
        emails.Add(new Email("veronika", "ola", "nice", "body4", DateTime.Now));
        emails.Add(new Email("veronika", "ola", "boo", "body5", DateTime.Now));
    }
}