namespace Prosjekt.Models
{
    public class ServiceFormModel
    {

        [Required]
        public int FormID_int { get; set; }
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
        [Required]
        public CustomerModel Customer_model { get; set; }
        [Required]
        public UsedPartModel UsedPartModel { get; set; }
        [Required]
        public ReplacedPartsReturnedModel ReplacedPartsReturned { get; set;}
        [Required]
        public ServiceFormEmployeeModel ServiceFormEmployee { get; set; }

            //trenger kanskje data for signatur, eventuelt erstatte det -
            // med noe annet som kan etterligne en signatur.

       
    }
}

