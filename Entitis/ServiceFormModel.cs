namespace Prosjekt.Entities
{
    public class ServiceFormModel
    {

        public int FormID_int { get; set; }
        public int CustomerID_int { get; set; }
        public string Repairdescription_str { get; set; }
        public DateOnly ServiceCompleted_date { get; set; }
        public DateOnly AgreedDelivery_date { get; set; }
        public DateOnly ProductRecived_date { get; set; }
        public int BookedServiceWeek_int { get; set; }
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

