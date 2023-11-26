using Prosjekt.Entities;
using Prosjekt.Data;

namespace Prosjekt.Repository
{
    public class EquipmentRepository : IEquipmentRepository, IDisposable
    {
        private ProsjektContext _context;

        public EquipmentRepository(ProsjektContext context)
        {
            _context = context;
        }
        public void DeleteEquipment(int id)
        {
            EquipmentModel model = _context.Equipment.Find(id);
            if (model != null)
            {
                var parts =_context.Parts.Where(x => x.EquipmentID_int == id).ToList();

                foreach (var part in parts)
                {
                    part.EquipmentID_int = null;
                }
                Save();
                _context.Equipment.Remove(model);
            }
        }


        public List<EquipmentModel> getAllEquipment()
        {
            return _context.Equipment.ToList();
        }

        public EquipmentModel getEquipmentByID(int id)
        {
            return _context.Equipment.Find(id);
        }

        public EquipmentModel getEquipmentByName(string name)
        {
            return _context.Equipment.FirstOrDefault(e => e.Name_str == name);
        }
        public void InsertEquipment(EquipmentModel model)
        {
            _context.Equipment.Add(model);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateEquipment(EquipmentModel model)
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
