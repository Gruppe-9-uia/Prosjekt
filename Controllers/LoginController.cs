using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models;

namespace Prosjekt.Controllers
{
    public class AccountController : Controller
    {
        private const string IsLoggedInCookie = "IsLoggedIn";

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel user)
        {
            // Forenklet logikk: bruker samme brukernavn og passord
            // koble mot en database
            if (user.Username == "test" && user.Password == "passord")
            {
                // Opprett en cookie for å indikere brukeren er logget inn
                Response.Cookies.Append(IsLoggedInCookie, "true");

                return RedirectToAction("Welcome");
            }

            ModelState.AddModelError("", "Invalid username or password.");
            return View();
        }

        public ActionResult Logout()
        {
            // Fjern cookien
            Response.Cookies.Delete(IsLoggedInCookie);

            return RedirectToAction("Login");
        }

        public ActionResult Welcome()
        {
            // Sjekk cookien for å avgjøre om brukeren er logget inn
            var isLoggedIn = Request.Cookies[IsLoggedInCookie];
            if (string.IsNullOrEmpty(isLoggedIn) || isLoggedIn != "true")
            {
                return RedirectToAction("Login");
            }

            return View();
        }
    }
}