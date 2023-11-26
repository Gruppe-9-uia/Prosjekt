using Prosjekt.Entities;

namespace Prosjekt.Repository
{
    public interface IWarrantyRepository
    {

        WarrantyModel getWarrantyByName(string name);
        void updateWarranty(WarrantyModel model);
        void InsertWarranty(WarrantyModel model);
        void DeleteWarrant(string name);
        void Save();
    }
}
