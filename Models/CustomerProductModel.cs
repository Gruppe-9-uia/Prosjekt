namespace Prosjekt.Models
{
    public class CustomerProductModel
    {
        [Required]
        public ProductModel Product { get; set; }
        [Required]
        public CustomerModel Customer { get; set; }
        [Required]
        public WarrantyModel Warranty { get; set; }
    }
}
