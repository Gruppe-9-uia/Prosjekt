namespace Prosjekt.Models
{
    public class DepartmentModel
    {
        [Required]
        [Key]
        public int DepartmentID_int { get; set; }
        [Required]
        public string Department_name_str { get; set;}
        public ICollection<EmployeeModel> Employees { get;}
    }
}
