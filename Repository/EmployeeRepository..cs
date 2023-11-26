using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Prosjekt.Entities;

namespace Prosjekt.Repository
{
    public class EmployeeRepository : IEmployeeRepository, IDisposable
    {
        private ProsjektContext _context;

        public EmployeeRepository(ProsjektContext context)
        {
            _context = context;
        }

        public void DeleteUser(string email)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Email.Equals(email));
            if (employee != null)
            {
              _context.SaveChanges();
                _context.Employees.Remove(employee);
            }
        }

        public List<EmployeeUser> getAllUsers()
        {
            return _context.Employees.ToList();
        }

        public EmployeeUser getUserByEmail(string? email)
        {
            return _context.Employees.FirstOrDefault(x => x.Email.Equals(email));
        }

        public void InsertUser(EmployeeUser model)
        {
            _context.Employees.Add(model);
        }

        public IdentityUserRole<string> getUserRole(string id)
        {
            return _context.UserRoles.FirstOrDefault(x => x.UserId.Equals(id));
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateUser(EmployeeUser model)
        {
            _context.Entry(model).State = EntityState.Modified;
        }

        public void updateUserRole(IdentityUserRole<string> model)
        {
            _context.Entry(model).State = EntityState.Modified;
        }

        //Hentet fra https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
