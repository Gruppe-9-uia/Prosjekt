using Prosjekt.Models;
using Prosjekt.Models.ServiceOrdre;

namespace Prosjekt.Data
{
    public class ProsjektContext : DbContext
    {
        public ProsjektContext(DbContextOptions<ProsjektContext> options) : base (options) { }

        public DbSet<AddressModel> Address { get; set; }
        public DbSet<CustomerModel> Customer { get; set; }
        public DbSet<WarrantyModel> Warranty { get; set; }
        public DbSet<ProductModel> Product { get; set; }
        public DbSet<CustomerProductModel> CustomerProduct { get; set; }
        public DbSet<DepartmentModel> Department { get; set; }
        public DbSet<EmployeeModel> Employee { get; set; }
        public DbSet<ServiceOrdreModel> ServiceOrdre { get; set; }
        public DbSet<ServiceFormModel> ServiceForm { get; set; }
        public DbSet<ServiceOrderServiceformModel> ServiceOrderServiceform { get; set; }
        public DbSet<ServiceFormEmployeeModel> ServiceFormEmployee { get; set; }
        public DbSet<ServiceFormSignModel> ServiceFormSign { get; set; }
        public DbSet<ChecklistModel> Checklist { get; set; }
        public DbSet<PartsModel> Parts { get; set; }
        public DbSet<ReplacedPartsReturnedModel> ReplacedParts { get; set; }
        public DbSet<UsedPartModel> UsedParts { get; set; }
    }
}
