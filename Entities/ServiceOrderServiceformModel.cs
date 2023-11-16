namespace Prosjekt.Entities
{
    public class ServiceOrderServiceformModel
    {
        [Required]
        [ForeignKey("OrderID_int")]
        [Key]
        public int OrderID_int { get; set; }
        [Required]
        [ForeignKey("FormID_int")]
        [Key]
        public int FormID_int { get; set; }
        public ServiceOrderModel ServiceOrder {  get; set; }
        public ServiceFormModel serviceForm { get; set; }

        public CustomerProductModel CustomerProduct { get; set; }

    }
}
