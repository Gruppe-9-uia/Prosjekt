namespace Prosjekt.Entities
{
    public class PartsModel
    {
        public int PartID_int { get; set; }
        [StringLength(50)]
        public string PartName_str { get; set;}
        public int Quantity_available_int { get; set; }
        public int? EquipmentID_int { get; set; }

        public EquipmentModel Equipment { get; set; }
        public ICollection<UsedPartModel> UsedParts {  get; set; }
        public ICollection<ReplacedPartsReturnedModel> ReplacedPartsReturned { get; set; }
    }
}
