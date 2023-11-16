namespace Prosjekt.Entities
{
    public class PartsModel
    {
        [Required]
        [Key]
        public int PartID_int { get; set; }
        [Required] 
        public string PartName_str { get; set;}
        [Required]
        public int Quantity_available_int { get; set; }

        public UsedPartModel UsedPart {  get; set; }
        public ReplacedPartsReturnedModel ReplacedPartsReturned { get; set; }
    }
}
