namespace Prosjekt.Models
{
    public class ServiceFormEmployeeModel
    {
        [Required]
        public int FormID_int { get; set; }
        [Required]
        public int EmployeeID_int { get; set; }
        [Required]
        public int Working_Hours_int { get; set; }
        [Required]
        public string Repair_Description_str { get; set; }
    }
}
