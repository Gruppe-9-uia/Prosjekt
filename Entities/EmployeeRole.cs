using Microsoft.AspNetCore.Identity;

namespace Prosjekt.Entities
{
    public class EmployeeRole : IdentityRole<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
