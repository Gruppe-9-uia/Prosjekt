using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models.Employee;

namespace Prosjekt.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ProsjektContext _context;

        public EmployeesController(ProsjektContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Employees()
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
                        Department = userRoleId.RoleId,
                        Phone = e.PhoneNumber,
                        Email = e.Email

                    };
                    list.Add(employeeObj);
                }

                if (list.Count > 0)
                {
                    ViewData["List"] = list;

                }
                return View();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return View();
            }

        }

        [HttpPost]
        public IActionResult UpdateEmployee(BrukerOversiktViewModel model)
        {

            var employeeDB = _context.Employees.Where(x => x.Id.Equals(model.ID_int)).FirstOrDefault();

            if (employeeDB != null)
            {
                employeeDB.Email = model.Email;
                employeeDB.PhoneNumber = model.Phone;
                employeeDB.FirstName_str = model.FirstName_str;
                employeeDB.LastName_str = model.LastName_str;

                var UserRolesDB = _context.UserRoles.Where(x => x.UserId.Equals(model.ID_int)).FirstOrDefault();

                _context.UserRoles.Remove(UserRolesDB);

                _context.SaveChanges();
                var newRole = new IdentityUserRole<string>
                {
                    RoleId = model.Department,
                    UserId = model.ID_int
                };
                _context.UserRoles.Add(UserRolesDB);

                _context.SaveChanges();
            }
            
            return RedirectToAction("Employees");

        }

        [HttpPost]
        public IActionResult RemoveEmployee(BrukerOversiktViewModel model)
        {


            var employeeDB = _context.Employees.Where(x => x.Id.Equals(model.ID_int)).FirstOrDefault();
            if(employeeDB != null)
            {
                _context.Employees.Remove(employeeDB);
                _context.SaveChanges();
            }

            return RedirectToAction("Employees");
        }

    }
}
