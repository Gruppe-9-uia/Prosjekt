using Microsoft.AspNetCore.Identity;
using Prosjekt.Entities;

namespace Prosjekt.Repository
{
    public interface IPostalCodeRepository
    {
        PostalCode getPostalCodeByID(string? Id);
        void updatePostalcode(PostalCode model);
        void InsertPostalCode(PostalCode model);
        void DeletePostalCode(string Id);
        void Save();
    }
}
