using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prosjekt.Entities;
using SQLitePCL;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Prosjekt.Controllers
{
    
    public class BrukerregistreringController : Controller
    {
        private readonly ProsjektContext _context;
        
            public BrukerregistreringController(ProsjektContext context)
            {
                _context = context;
            }
            
        // GET: /<controller>/
        public IActionResult Brukerregistrering()
        {
            return View();
        }

        public IActionResult CreateUser()
        {
            return RedirectToAction("Brukerregistrering");
        }

        [HttpPost]
        public IActionResult RegistreringFrom(AddEmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                var names = employee.FulltNavn.Split(' ');
                if (names.Length >= 2)
                _context.Add(employee);
                _context.SaveChanges();
                {
                    employee.FirstName_str = names[0];
                    employee.LastName_str = names[1];
                }
                return RedirectToAction("Brukeroversikt", "Brukeroversikt");
            }
            return View("Brukerregistrering");
        }
    }
}

