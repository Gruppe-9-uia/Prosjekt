using Prosjekt.Entities;

namespace Prosjekt.Repository
{
    public class ProductRepositorty : IProductRepositorty, IDisposable
    {
        private ProsjektContext _context;

        public ProductRepositorty(ProsjektContext context)
        {
            _context = context;
        }
        public void DeleteParts(string id)
        {
            var product = _context.Product.Find(id);
            if(product  != null)
            {
                _context.Product.Remove(product);
            }
        }

        public ProductModel? findProductByID(string? id)
        {
            return _context.Product.Find(id);
        }

        public ProductModel getProductByID(string? id)
        {
            return _context.Product.Find(id);
        }

        public void InsertProductModel(ProductModel model)
        {
            _context.Product.Add(model);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateProduct(ProductModel model)
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
