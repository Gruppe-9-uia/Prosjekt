using Microsoft.AspNetCore.Identity;

namespace Prosjekt.Entities
{
    public class EmployeeRole : IdentityRole<Guid>
    {
        public int id { get; set; }
        public string name { get; set; }   
    }
}
