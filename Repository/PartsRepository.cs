using Microsoft.EntityFrameworkCore;
using Prosjekt.Entities;

namespace Prosjekt.Repository
{
    public class PartsRepository : IPartsRepository, IDisposable
    {
        private ProsjektContext _context;

        public PartsRepository(ProsjektContext context)
        {
            _context = context;
        }

        public void DeleteParts(int id)
        {
            PartsModel partsModel = _context.Parts.Find(id);
            if(partsModel != null)
            {
                _context.Parts.Remove(partsModel);
            }
        }

        public List<PartsModel> getAllParts()
        {
            return _context.Parts.ToList();
        }

        public PartsModel getPartsByID(int id)
        {
            return _context.Parts.Find(id);
        }

        public PartsModel getPartsByName(string name)
        {
            return _context.Parts.FirstOrDefault(x => x.PartName_str.Equals(name));
        }

        public EquipmentModel? findPartsByEquipmentName(string? equipmentName)
        {
            return _context.Equipment.FirstOrDefault(x => x.Name_str.Equals(equipmentName));
        }

        public EquipmentModel? findPartsByEquipmentId(int? equipmentId)
        {
            return _context.Equipment.FirstOrDefault(x => x.Id_int == equipmentId);
        }

        public void InsertParts(PartsModel model)
        {
            _context.Parts.Add(model);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateParts(PartsModel model)
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
