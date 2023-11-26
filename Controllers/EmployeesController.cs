using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prosjekt.Models.Employee;
using Prosjekt.Repository;

namespace Prosjekt.Controllers
{
    public class EmployeesController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        private readonly ILogger<EmployeesController> _logger;

        public EmployeesController(IEmployeeRepository employeeRepository, ILogger<EmployeesController> logger) 
        {
            _employeeRepository = employeeRepository;
            _logger = logger;
        }
        // GET: /<controller>/
        public IActionResult Employees()
        {
            var employeeList = _employeeRepository.getAllUsers();

            //make a list of users in the system
            List<BrukerOversiktViewModel> list = new List<BrukerOversiktViewModel>();
            foreach (var e in employeeList)
            {
                //Getinng the role to user
                var userRoleId =_employeeRepository.getUserRole(e.Id);

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

            ViewData["List"] = list;

            return View();

        }

        [HttpPost]
        public IActionResult UpdateEmployee(EmployeeUpdateModel model)
        {
            if (!ModelState.IsValid)
            {
                //_logger.Log("Model state was not true");
                return View();
            }

            // update user if exists with new data
            var userUpdate = _employeeRepository.getUserByEmail(model.Email);
            if (userUpdate != null)
            {
                userUpdate.Email = model.Email;
                userUpdate.UserName = model.Email;
                userUpdate.NormalizedEmail = model.Email.ToUpper();
                userUpdate.NormalizedEmail = model.Email.ToUpper();
                userUpdate.FirstName_str = model.FirstName_str;
                userUpdate.PhoneNumber = model.Phone;

                //update the users role
                var newRole = new IdentityUserRole<string>
                {
                    RoleId = model.Department,
                    UserId = userUpdate.Id
                };
                _employeeRepository.updateUserRole(newRole);
                _employeeRepository.UpdateUser(userUpdate);
                _employeeRepository.Save();


            }

            return RedirectToAction("Employees");

        }

        [HttpPost]
        public IActionResult RemoveEmployee(BrukerOversiktViewModel model)
        {

            //Removing the user from the database
            _employeeRepository.DeleteUser(model.Email);
            _employeeRepository.Save();

            return RedirectToAction("Employees");
        }

    }
}
