using Prosjekt.Entities;

namespace Prosjekt.Repository
{
    public interface ICustomerRepository
    {
        CustomerModel getCustomerByID(string Id);
        void updateCustomer(CustomerModel model);
        void InsertCustomer(CustomerModel model);
        void DeleteCustomer(string Id);
        void Save();
    }
}
