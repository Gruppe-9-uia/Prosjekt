﻿using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models;
using System.Net;
using System.Net.Http;
using System.Net.Mail;

namespace Prosjekt.Controllers
{
    public class KontaktController : Controller
    {
        public IActionResult KontaktOss()
        {
            return View();
        }

        // Funskjon vil gi bruker resposen om det var vellykke eller ikke
        // ved innsending av form
        [HttpPost]
        public IActionResult SumbitKontaktForm(KontaktFormModel kontaktForm)
        {
            if (!ModelState.IsValid) return View("KontaktOss");

            try
            {
                //Hentet fra https://stackoverflow.com/questions/17962784/using-mailmessage-to-send-emails-in-c-sharp
                MailMessage mail = new MailMessage();

                //mail addressen den sender fra
                mail.From = new MailAddress("gruppe9Uia@outlook.com");

                //Emnet til mailen
                mail.Subject = "Kontakt form";

                //innholdet i mail
                mail.Body = $"Hei {kontaktForm.navn}\nTusen takk at du sendt din meldin. Vi vil kontakt deg snartest som mulig\n Hilsen Gruppe 9";
                mail.IsBodyHtml = true;

                //mottaker
                mail.To.Add(kontaktForm.email);
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
                Console.WriteLine("Email Sent Successfully.");
            }
            catch (Exception ex) { 
            
                //Burde skrive ut error melding eller logge den
                Console.WriteLine(ex.ToString());
            }

            return RedirectToAction("KontaktOss");
        
        }
    }
}