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

            try
            {
                var  db = _context.Employee
                    .Where(e => e.Email_str == employee.Email_str)
                    .SingleOrDefault();

                Console.WriteLine(db.Email_str);
                // (logikk for å linke brukernavn og passord til en database her)
                if (db != null && employee.Email_str == db.Email_str && employee.Password_str == db.Password_str)
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


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }



            // dersom logg inn feiler, tilbake til login med error melding
            return RedirectToAction("Login");
        }
    }
}
