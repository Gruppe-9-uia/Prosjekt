using Microsoft.EntityFrameworkCore;
using Prosjekt.Entities;

namespace Prosjekt.Repository
{

    public class PostalCodeRepository : IPostalCodeRepository, IDisposable
    {

        private ProsjektContext _context;

        public PostalCodeRepository(ProsjektContext context)
        {
            _context = context;
        }

        public void DeletePostalCode(string Id)
        {
            var postalCode = _context.Postal_Code.FirstOrDefault(x => x.Postal_Code_str.Equals(Id));
            if(postalCode != null)
            {
                _context.Postal_Code.Remove(postalCode);
            }
        }

        public PostalCode getPostalCodeByID(string? Id)
        {
            return _context.Postal_Code.FirstOrDefault(x => x.Postal_Code_str.Equals(Id));
        }

        public void InsertPostalCode(PostalCode model)
        {
            _context.Postal_Code.Add(model);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void updatePostalcode(PostalCode model)
        {
            //Hentet fra https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
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

