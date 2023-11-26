using Prosjekt.Entities;

namespace Prosjekt.Repository
{
    public class ServiceordreRepository : IServiceordreRepository, IDisposable
    {
        private ProsjektContext _context;
        public ServiceordreRepository(ProsjektContext context) {
            _context = context;
        }
        public void DeleteOrder(int id)
        {
            var serviceOrder = _context.Service_ordre.FirstOrDefault(x => x.OrderID_int == id);
            if (serviceOrder != null)
            {
                _context.Service_ordre.Remove(serviceOrder);
            }
        }

        public List<ServiceOrderModel> getAllOrder()
        {
            return _context.Service_ordre.ToList();
        }

        public ServiceOrderModel getOrderByID(int id)
        {
            return _context.Service_ordre.FirstOrDefault(x => x.OrderID_int == id);

        }

        public void InsertOrder(ServiceOrderModel model)
        {

            _context.Service_ordre.Add(model);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateOrder(ServiceOrderModel model)
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
