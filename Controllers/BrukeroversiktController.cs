using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models.Employee;

namespace Prosjekt.Controllers
{
    public class BrukeroversiktController : Controller {
    
    private readonly ProsjektContext _context;

    public BrukeroversiktController(ProsjektContext context)
    {
        _context = context;
    }
        // GET: /<controller>/
        public IActionResult Brukeroversikt()
        {
            try
            {
                var employeeList = _context.Employees.ToList();

                List<BrukerOversiktViewModel> list = new List<BrukerOversiktViewModel>();

                // Convert the fetched data to the view model type
                foreach (var e in employeeList)
                {
                    var userRoleId = _context.UserRoles.Where(x => x.UserId.Equals(e.Id)).FirstOrDefault();
                    if (userRoleId == null)
                    {
                        ModelState.AddModelError(string.Empty, "Feil å hente rolle");
                    }

                    var employeeObj = new BrukerOversiktViewModel
                    {
                        ID_int = e.Id,
                        FirstName_str = e.FirstName_str,
                        LastName_str = e.LastName_str,
                        Department = userRoleId.RoleId

                    };
                    list.Add(employeeObj);
                }

                if (list.Count > 0)
                {
                    ViewData["List"] = list;

                }
                return View();

            } catch (Exception ex) { 
                Console.WriteLine(ex);
                return View();
            }
            
        }

        public IActionResult BackBrukeroversikt()
        {
            return RedirectToAction("Brukeroversikt");
        }
        
        
        public IActionResult GetEmployeeDetails(int employeeID)
        {
            // TODO: burde kanskje gjør om user id til int

            var employee = _context.Users.FirstOrDefault(e => e.Id == employeeID.ToString());
            if (employee != null)
            { 
                return Json(new {Email = employee.Email, Phone = employee.PhoneNumber});
            }

            return Json(null);
        }

        
       
    }
}
