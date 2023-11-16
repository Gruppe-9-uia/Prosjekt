using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models;

namespace Prosjekt.Controllers
{
    public class LoginController : Controller
    {
        private readonly ProsjektContext _context;
        // GET

        public LoginController(ProsjektContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View("Login");
        }

        // POS
        public IActionResult LoginUser(LoginModel employee) {


            // dersom logg inn feiler, tilbake til login med error melding
            return RedirectToAction("Login");
        }

        public IActionResult ForgotPassword()
        {
            // Display the form for forgot password
            return View("ForgotPassword");
        }

        [HttpPost]
        public IActionResult ForgotPassword(ForgotPasswordModel model)
        {
            // Handle the form submission and any necessary logic
            // Redirect to the appropriate action based on the result

            return RedirectToAction("ForgotPassword");
        }
    }
}
