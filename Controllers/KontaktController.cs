using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models;
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
        public IActionResult KontaktOss(KontaktFormModell kontaktForm)
        {
            if (!ModelState.IsValid) return View();

            try
            {
                MailMessage mail = new MailMessage();

                //mail addressen den sender fra
                mail.From = new MailAddress("");

            }catch (Exception ex) { 
            
                //Burde skrive ut error melding eller logge den
            }

            return View();
        
        }
    }
}
