using Microsoft.EntityFrameworkCore;
using Prosjekt.Entities;
using System.Runtime.Intrinsics.X86;

namespace Prosjekt.Repository
{
    public class CustomerRepository : ICustomerRepository, IDisposable
    {
        private ProsjektContext _context;

        public CustomerRepository(ProsjektContext context) {
            _context = context;
        }

        public void DeleteCustomer(string Id)
        {
            var customer = _context.Customer.FirstOrDefault(x => x.Email_str.Equals(Id));
            if (customer != null)
            {
                _context.Customer.Remove(customer);
            }
        }

        public CustomerModel getCustomerByID(string Id)
        {
            return _context.Customer.FirstOrDefault(x => x.Email_str.Equals(Id));
        }

        public void InsertCustomer(CustomerModel model)
        {
            _context.Customer.Add(model);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void updateCustomer(CustomerModel model)
        {
            // Hentet fra https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
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
