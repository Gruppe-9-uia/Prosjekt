using Microsoft.AspNetCore.Identity;

namespace Prosjekt.Entities;

[Table("Employee")]
public class EmployeeUser : IdentityUser
{
    
    [Required]
    [ForeignKey("DepartmentID_int")]
    public int DepartmentID_int { get; set; }

    [Required] public string FirstName_str { get; set; }
    [Required] public string LastName_str { get; set; }
    [Required] public string PhoneNumber { get; set; }

    public bool RememberMe { get; set; }

    //TODO: kanskje gjør det om til emun
    [Required] public string Level_str { get; set; }

    public DepartmentModel? Department { get; set; }
    public ChecklistSignatureModel? ChecklistSignature { get; set; }
    public ICollection<ServiceFormEmployeeModel>? ServiceFormEmployees { get; set; }
    public ICollection<ServiceFormSignModel>? ServiceFormsSign { get; }
}