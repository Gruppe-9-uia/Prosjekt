namespace Prosjekt.Models
{
    public class ServiceFormSignModel
    {
        [Required]
        [Key]
        [ForeignKey("CustomerID_int")]
        public int CustomerID_int { get; set; }
        [Required]
        [Key]
        [ForeignKey("EmployeeID_int")]
        public int EmployeeID_int { get; set; }
        [Required]
        [Key]
        [ForeignKey("FormID_int")]
        public int FormID_int { get; set; }
        [Required]
        public DateOnly Sign_Date { get; set;}

        public CustomerModel Customer { get; set; }
        public EmployeeModel Employee { get; set; }
        public ServiceFormModel ServiceForm { get; set; }
    }
}
