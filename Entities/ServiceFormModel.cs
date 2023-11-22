namespace Prosjekt.Entities
{
    public class ServiceFormModel
    {

        public int FormID_int { get; set; }
        [StringLength(255)]
        public string Repairdescription_str { get; set; }
        public DateOnly ServiceCompleted_date { get; set; }
        public DateOnly AgreedDelivery_date { get; set; }
        public DateOnly ProductRecived_date { get; set; }
        public int BookedServiceWeek_int { get; set; }
        [StringLength(50)]
        public string ShippingMethod_str { get; set; }

        public ServiceOrderServiceformModel OrderServiceformModel { get; set; }
        public ServiceFormSignModel Sign {  get; set; }
        public ServiceFormEmployeeModel Employee { get; set; }
        public UsedPartModel UsedPart { get; set; }

        public ReplacedPartsReturnedModel ReplacedPartsReturned { get; set; }


    }
}

