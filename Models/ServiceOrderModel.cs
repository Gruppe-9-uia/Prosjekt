namespace Prosjekt.Models
{
    public class ServiceOrderModel
    {
        public int OrderID_int { get; set; }
        [Required]
        [StringLength(50)]
        public string Order_type_str { get; set; }
        public DateOnly Received_Date { get; set; }
        [Required]
        [StringLength(255)]
        public string Description_From_Customer_str { get; set; }
        public CustomerModel CustomerModel { get; set; }

        public CustomerProductModel CustomerProductModel { get; set; }
    }
}
