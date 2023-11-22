using Prosjekt.Entities;

namespace Prosjekt.Entities
{
    public class ServiceOrderModel
    {
        public int OrderID_int { get; set; }
        public string SerialNr_str { get; set; }
        public int CustomerID_int { get; set; }
        public int CustomerId {  get; set; }
        [StringLength(50)]
        public string Order_type_str { get; set; }
        public DateOnly Received_Date { get; set; }
        [StringLength(255)]
        public string Description_From_Customer_str { get; set; }

        public ServiceOrderServiceformModel OrderServiceformModel { get; set; }
        public CustomerModel Customer { get; set; }
       // public ServiceOrderServiceformModel ServiceOrderServiceform { get; set; }

        //TODO: muligens fjernes?
        public CustomerProductModel CustomerProductModel { get; set; }
    }
}
