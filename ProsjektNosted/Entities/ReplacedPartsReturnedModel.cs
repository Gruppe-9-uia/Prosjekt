namespace Prosjekt.Entities
{
    public class ReplacedPartsReturnedModel
    {
     

        public int PartID_int { get; set; }
        public int FormID_int { get; set; }
        public int Quantity_int { get; set; }
        public PartsModel Parts { get; set; }
        public ServiceFormModel ServiceForm;

    }
}
