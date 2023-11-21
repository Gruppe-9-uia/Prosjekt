namespace Prosjekt.Entities
{
    public class ServiceFormModel
    {

        [Required]
        [Key]
        public int FormID_int { get; set; }
        [Required]
        [Key]
        [ForeignKey("CustomerID_int")]
        public int CustomerID_int { get; set; }
        [Required]
        public string Repairdescription_str { get; set; }
        [Required]
        public DateOnly ServiceCompleted_date { get; set; }
        [Required]
        public DateOnly AgreedDelivery_date { get; set; }
        [Required]
        public DateOnly ProductRecived_date { get; set; }
        [Required]
        public int BookedServiceWeek_int { get; set; }
        [Required]
        public string ShippingMethod_str { get; set; }

        public CustomerModel Customer { get; set; }
        public ServiceOrderServiceformModel ServiceOrderServiceform { get; set; }
        public ServiceFormEmployeeModel ServiceFormEmployee { get; set; }
        public ServiceFormSignModel ServiceFormSign { get; set; }

        public UsedPartModel UsedPart { get; set; }

        public ReplacedPartsReturnedModel ReplacedPartsReturned { get; set;}

            //trenger kanskje data for signatur, eventuelt erstatte det -
            // med noe annet som kan etterligne en signatur.

       
    }
}

