namespace Prosjekt.Models
{
    public class CustomerProductModel
    {

        [Required]
        [Key]
        [ForeignKey("SerialNr_str")]
        public string SerialNr_str { get; set; }
        [ForeignKey("CustomerID_int")]
        [Required]
        [Key]
        public int CustomerID_int { get; set; }
        [Required]
        [ForeignKey("WarrantyID_int")]
        public int WarrantyID_int { get; set; }

        public ProductModel Product { get; set; }
        public CustomerModel Customer { get; set; }
        public WarrantyModel Warranty { get; set; }
        
    }
}
