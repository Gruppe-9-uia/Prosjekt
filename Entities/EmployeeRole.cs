using Microsoft.AspNetCore.Identity;

namespace Prosjekt.Entities
{
    public class EmployeeRole : IdentityRole<int>
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public int UserId { get; set; }
        public virtual EmployeeUser User { get; set; }
    }
}
