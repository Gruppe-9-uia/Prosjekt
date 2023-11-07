namespace Prosjekt.Models
{
    public class UsedPartModel
    {
        [Required]
        public int PartID_int { get; set; }
        [Required]
        public int FormID_int { get; set; }
        [Required]
        public int Quantity_int { get; set; }
        [Required]
        public PartsModel Parts { get; set; }
    }
}
