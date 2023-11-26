using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;
namespace Prosjekt.Services
{

    public class MyEmailSender : IEmailSender
    {

        public Task SendEmailAsync(string email, string subject, string message)
        {
            try
            {
                Console.WriteLine(email);
                Console.WriteLine(subject);
                Console.WriteLine(message);

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }

            return Task.CompletedTask;
        }
    }
}
