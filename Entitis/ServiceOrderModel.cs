namespace Prosjekt.Entities
{
    public class ServiceOrderModel
    {
        public int OrderID_int { get; set; }
        public int CustomerID_int { get; set; }
        public string Order_type_str { get; set; }
        public DateOnly Received_Date { get; set; }
        public string Description_From_Customer_str { get; set; }
        public CustomerModel Customer { get; set; }
        public ServiceOrderServiceformModel ServiceOrderServiceform { get; set; }

        //TODO: muligens fjernes?
        public CustomerProductModel CustomerProductModel { get; set; }
    }
}
