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
                MailMessage mail = new MailMessage();

                
                //mail addressen den sender fra
                mail.From = new MailAddress("gruppe9Uia@outlook.com");

                //Emnet til mailen
                mail.Subject = subject;

                //innholdet i mail
                mail.Body = message;
                mail.IsBodyHtml = true;
                
                mail.To.Add(email);
                //Passord UiaProsjekt
                //Email gruppe9Uia@gmail.com
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.office365.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("gruppe9Uia@outlook.com", "UiaProsjekt");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;

                //hentet fra https://stackoverflow.com/questions/2859790/the-request-was-aborted-could-not-create-ssl-tls-secure-channel
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                // TODO: handle exception
                throw new InvalidOperationException(ex.Message);
            }

            return Task.CompletedTask;
        }
    }
}
