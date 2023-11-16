using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Prosjekt.Controllers
{
    public class BrukeroversiktController : Controller {
    
    private readonly ProsjektContext _context;
    // GET

    public BrukeroversiktController(ProsjektContext context)
    {
        _context = context;
    }
        // GET: /<controller>/
        public IActionResult Brukeroversikt()
        {
            var employees = _context.Employees.ToList();
            
            return View(employees);
        }

        public IActionResult BackBrukeroversikt()
        {
            return RedirectToAction("Brukeroversikt");
        }
        
        
        public IActionResult GetEmployeeDetails(int employeeID)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.ID_int == employeeID);
            if (employee != null)
            {
                return Json(new {Email = employee.Email_str, Phone = employee.Phone_str});
            }

            return Json(null);
        }

        
       
    }
}
