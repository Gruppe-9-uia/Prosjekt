namespace Prosjekt.Models
{
    public class ServiceFormEmployeeModel
    {
        [Required]
        [Key]
        [ForeignKey("FormID_int")]
        public int FormID_int { get; set; }
        [Required]
        [Key]
        [ForeignKey("EmployeeID_int")]
        public int EmployeeID_int { get; set; }
        [Required]
        public int Working_Hours_int { get; set; }
        [Required]
        public string Repair_Description_str { get; set; }

        public ServiceFormModel ServiceForm {get; set; }
        public EmployeeModel Employee { get; set; }
    }
}
