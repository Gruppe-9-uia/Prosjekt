using Prosjekt.Entities;

namespace Prosjekt.Repository
{
    public interface IServiceordreRepository
    {
        List<ServiceOrderModel> getAllOrder();
        ServiceOrderModel getOrderByID(int id);
        void InsertOrder(ServiceOrderModel model);
        void UpdateOrder(ServiceOrderModel model);
        void DeleteOrder(int id);
        void Save();
    }
}
