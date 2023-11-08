namespace Prosjekt.Models
{
    public class WarrantyModel
    {
        [Required]
        [Key]
        public int ID_int { get; set; }
        [Required]
        public string WarrantyName_str { get; set; }
        [Required]
        public string WarrantyType_str { get; set; }
        [Required]
        public DateOnly StartDate_date { get; set; }
        [Required]
        public DateOnly ExpDate_date { get; set; }
        public CustomerProductModel CustomerProduct { get; set; }

    }
}
