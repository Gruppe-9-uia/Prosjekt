using Microsoft.AspNetCore.Identity;
using Prosjekt.Entities;

namespace Prosjekt.Repository
{
    public interface IEmployeeRepository
    {
        List<EmployeeUser> getAllUsers();
        EmployeeUser getUserByEmail(string? email);
        IdentityUserRole<string> getUserRole(string id);
        void updateUserRole(IdentityUserRole<string> model);
        void InsertUser(EmployeeUser model);
        void UpdateUser(EmployeeUser model);
        void DeleteUser(string email);
        void Save();
    }
}
