using Prosjekt.Entities;

namespace Prosjekt.Entities
{
    public class DepartmentModel
    {
        [Required]
        [Key]
        public int ID_int { get; set; }
        [Required]
        public string Department_name_str { get; set;}
        public ICollection<EmployeeUser> Employees { get;}
    }
}
