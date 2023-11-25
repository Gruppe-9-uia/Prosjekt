using Microsoft.AspNetCore.Identity;

namespace Prosjekt.Entities;

[Table("Employee")]
public class EmployeeUser : IdentityUser
{
    [StringLength(20)]
    public string FirstName_str { get; set; }
    [StringLength(20)]
    public string LastName_str { get; set; }
    [StringLength(15)]
    public string PhoneNumber { get; set; }

    public bool RememberMe { get; set; }

    //TODO: kanskje gjør det om til emun
    

    public ServiceFormSignModel Sign { get; set; }

    public ServiceFormEmployeeModel EmployeeForm { get; set; }
    public ChecklistSignatureModel ChecklistSignature { get; set; }
}