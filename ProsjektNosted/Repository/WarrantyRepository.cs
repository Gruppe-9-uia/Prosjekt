using Microsoft.EntityFrameworkCore;
using Prosjekt.Entities;

namespace Prosjekt.Repository
{
    public class WarrantyRepository : IWarrantyRepository, IDisposable
    {
        private ProsjektContext _context;

        public WarrantyRepository( ProsjektContext context )
        {
            _context = context;
        }

        public void DeleteWarrant(string name)
        {
            throw new NotImplementedException();
        }

        public WarrantyModel getWarrantyByName(string name)
        {
            return _context.Warranty.FirstOrDefault(x => x.WarrantyName_str.Equals(name));
        }

        public void InsertWarranty(WarrantyModel model)
        {
            _context.Warranty.Add(model);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void updateWarranty(WarrantyModel model)
        {
            throw new NotImplementedException();
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
