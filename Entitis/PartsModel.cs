namespace Prosjekt.Entities
{
    public class PartsModel
    {
        public int PartID_int { get; set; }
        public string PartName_str { get; set;}
        public int Quantity_available_int { get; set; }

        public UsedPartModel UsedPart {  get; set; }
        public ReplacedPartsReturnedModel ReplacedPartsReturned { get; set; }
    }
}
