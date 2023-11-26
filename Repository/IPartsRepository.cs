using Prosjekt.Entities;

namespace Prosjekt.Repository
{
    public interface IPartsRepository
    {
        List<PartsModel> getAllParts();
        PartsModel getPartsByID(int id);
        PartsModel getPartsByName(string name);
        EquipmentModel? findPartsByEquipmentId(int?  equipmentId);
        EquipmentModel? findPartsByEquipmentName(string? equipmentName);
        void InsertParts(PartsModel model);
        void UpdateParts(PartsModel model);
        void DeleteParts(int id);
        void Save();
    }
}
