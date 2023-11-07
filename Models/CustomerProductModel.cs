namespace Prosjekt.Models
{
    public class CustomerProductModel
    {
        [Required]
        public string SerialNr_str { get; set; }
        [Required]
        public int CustomerID_int { get; set; }
        [Required]
        public int WarrantyID_int { get;set; }
    }
}
