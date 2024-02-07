using Blazor.Data.Models;

namespace Blazor.Data;

public interface IEmailService
{
    public void SentEmail(Email email);

}