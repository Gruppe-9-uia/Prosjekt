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
                        Department = userRoleId.RoleId

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
    }
}
