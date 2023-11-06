using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models;

namespace Prosjekt.Controllers
{
    public class LoginController : Controller
    {
        // GET
        public IActionResult Login()
        {
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)

            {
                // (logikk for å linke brukernavn og passord til en database her)

                if (model.Username == "validUsername" && model.Password == "validPassword")
                {

                    // Logg inn suksess, følg brukeren til hjemsiden
                    return RedirectToAction("Welcome", "Home");
                }
                else
                {
                    //  Add an error message to the ModelState.
                    //Logg inn feilet
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                }
            }


            // dersom logg inn feiler, tilbake til login med error melding
            return View(model);
        }
    }
}
