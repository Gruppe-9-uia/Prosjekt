namespace Prosjekt.Models
{
    public class ServiceFormSignModel
    {
        [Required]
        public int CustomerID_int { get; set; }
        [Required]
        public int EmployeeID_int { get; set; }
        [Required]
        public int FormID_int { get; set; }
        [Required]
        public DateOnly Sign_Date { get; set;}
    }
}
