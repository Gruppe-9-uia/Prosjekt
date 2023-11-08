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
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult LoginUser(EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("test");
            }

        
                // (logikk for å linke brukernavn og passord til en database her)
                var db = _context.Employee.Where(e => e.Email_str == employee.Email_str).Single();
                Console.WriteLine(db);
                if (employee.Email_str == db.Email_str && employee.Password_str == db.Password_str)
                {
                    Console.WriteLine("yay!");
                    // Logg inn suksess, følg brukeren til hjemsiden
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    //  Add an error message to the ModelState.
                    //Logg inn feilet
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                }
          


            // dersom logg inn feiler, tilbake til login med error melding
            return RedirectToAction("Login");
        }
    }
}
