using Prosjekt.Entities;

namespace Prosjekt.Repository
{
    public interface IEquipmentRepository
    {
        List<EquipmentModel> getAllEquipment();
        EquipmentModel getEquipmentByID(int id);
        EquipmentModel getEquipmentByName(string name);
        void InsertEquipment(EquipmentModel model);
        void UpdateEquipment(EquipmentModel model);
        void DeleteEquipment(int id);
        void Save();
    }
}
