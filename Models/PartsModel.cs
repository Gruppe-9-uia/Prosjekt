namespace Prosjekt.Models
{
    public class PartsModel
    {
        [Required]
        public int PartID_int { get; set; }
        [Required] 
        public string PartName_str { get; set;}
        [Required]
        public int Quantity_available_int { get; set; }
    }
}
