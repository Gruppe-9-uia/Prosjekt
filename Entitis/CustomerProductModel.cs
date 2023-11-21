namespace Prosjekt.Entities
{
    public class CustomerProductModel
    {

        public string SerialNr_str { get; set; }

        public int CustomerID_int { get; set; }

        public int WarrantyID_int { get; set; }

        public ProductModel Product { get; set; }
        public CustomerModel Customer { get; set; }
        public WarrantyModel Warranty { get; set; }

        public ICollection<ServiceOrderModel> ServiceOrders { get; }

    }
}
