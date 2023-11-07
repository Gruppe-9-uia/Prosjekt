namespace Prosjekt.Models
{
    public class ReplacedPartsReturnedModel
    {
        [Required] 
        public int PartID_int { get; set; }
        [Required]
        public int FormID_int { get; set; }
        [Required]
        public int Quantity_int { get; set; }
    }
}
