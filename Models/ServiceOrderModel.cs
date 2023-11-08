namespace Prosjekt.Models
{
    public class ServiceOrderModel
    {
        [Required]
        [Key]
        public int OrderID_int { get; set; }
        [Required]
        [Key]
        [ForeignKey("CustomerID_int")]
        public int CustomerID_int { get; set; }
        [Required]
        [StringLength(50)]
        public string Order_type_str { get; set; }
        public DateOnly Received_Date { get; set; }
        [Required]
        [StringLength(255)]
        public string Description_From_Customer_str { get; set; }
        public CustomerModel Customer { get; set; }
        public CustomerProductModel CustomerProduct { get; set; }
        public ServiceOrderServiceformModel ServiceOrderServiceform { get; set; }

        //TODO: muligens fjernes?
        public CustomerProductModel CustomerProductModel { get; set; }
    }
}
