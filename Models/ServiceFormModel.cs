using System.ComponentModel.DataAnnotations;

namespace Prosjekt.Models
{
    public class ServiceFormModel
    {
        [Required]
        public int FormID_int { get; set; }
        [Required]
        public string CustomerID_int { get; set; }
        [Required]
        public DateOnly ServiceCompleted_date { get; set; }
        [Required]
        public DateOnly ProductRecived_date { get; set; }
        [Required]
        public int BookedServiceWeek_int { get; set; }
        [Required]
        public string ShippingMethod_str { get; set; }
        //trenger kanskje data for signatur, eventuelt erstatte det -
        // med noe annet som kan etterligne en signatur.

    }
}