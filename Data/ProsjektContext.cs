using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Prosjekt.Entities;

namespace Prosjekt.Data
{
    public class ProsjektContext : IdentityDbContext<EmployeeUser, EmployeeRole,  int>
    {
        public ProsjektContext(DbContextOptions<ProsjektContext> options) : base (options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Setter opp relasjoner
            //modelBuilder.Ignore<IdentityUserLogin<string>>();
            //modelBuilder.Ignore<IdentityUserRole<string>>();
            //modelBuilder.Ignore<IdentityUserClaim<string>>();
            //modelBuilder.Ignore<IdentityUserToken<string>>();
            //modelBuilder.Ignore<IdentityUser<string>>();

            //TODO: fiks fforholdene mellom roles og user?

            //AddressModel
            modelBuilder.Entity<AddressModel>()
                .HasKey(a => a.Address_code_int);

            modelBuilder.Entity<AddressModel>()
                .HasMany(a => a.customers)
                .WithOne(c => c.Address)
                .HasForeignKey(a => a.Address_code_int);

            //CustomerModel
            modelBuilder.Entity<CustomerModel>()
                .HasKey(Customer => Customer.CustomerID_int);

            modelBuilder.Entity<CustomerModel>()
                .HasOne(c => c.Address)
                .WithMany(a => a.customers)
                .HasForeignKey(c => c.Address_code_int);

            modelBuilder.Entity<CustomerModel>()
                .HasMany(c => c.ServiceOrders)
                .WithOne(s => s.Customer)
                .HasForeignKey(c => c.CustomerID_int);

            modelBuilder.Entity<CustomerModel>()
                .HasMany(c => c.ServiceForms)
                .WithOne(s => s.Customer)
                .HasForeignKey(c => c.CustomerID_int);

            modelBuilder.Entity<CustomerModel>()
                .HasMany(c => c.CustomerProducts)
                .WithOne(cp => cp.Customer)
                .HasForeignKey(c => c.CustomerID_int);

            modelBuilder.Entity<CustomerModel>()
                .HasMany(c => c.ServiceFormsSign)
                .WithOne(s => s.Customer)
                .HasForeignKey(s => s.CustomerID_int);

            //WarrantyModel
            modelBuilder.Entity<WarrantyModel>()
              .HasKey(Warranty => Warranty.ID_int);

            modelBuilder.Entity<WarrantyModel>()
                .HasOne(w => w.CustomerProduct)
                .WithOne(c => c.Warranty)
                .HasPrincipalKey<CustomerProductModel>(c => c.WarrantyID_int);


            //ProductModel
            modelBuilder.Entity<ProductModel>()
                .HasKey(Product => Product.SerialNr_str);

            modelBuilder.Entity<ProductModel>()
                .HasOne(p => p.CustomerProduct)
                .WithOne(c => c.Product)
                .HasPrincipalKey<CustomerProductModel>(c => c.SerialNr_str);

            modelBuilder.Entity<ProductModel>()
                .HasOne(p => p.Checklist)
                .WithOne(c => c.product)
                .HasPrincipalKey<ChecklistModel>(s => s.SerialNr_str);

            //CustomerProductModel
            modelBuilder.Entity<CustomerProductModel>()
                .HasKey(c => new {
                    c.CustomerID_int,
                    c.SerialNr_str

                });

            modelBuilder.Entity<CustomerProductModel>()
                .HasOne(c => c.Warranty)
                .WithOne(w => w.CustomerProduct)
                .HasPrincipalKey<WarrantyModel>(c => c.ID_int);

            modelBuilder.Entity<CustomerProductModel>()
                .HasOne(c => c.Product)
                .WithOne(p => p.CustomerProduct)
                .HasPrincipalKey<ProductModel>(c => c.SerialNr_str);

            modelBuilder.Entity<CustomerProductModel>()
                .HasOne(cp => cp.Customer)
                .WithMany(c => c.CustomerProducts)
                .HasForeignKey(cp => cp.CustomerID_int);

            //DepartmentModel
            modelBuilder.Entity<DepartmentModel>()
                .HasKey(Department => Department.DepartmentID_int);

            modelBuilder.Entity<DepartmentModel>()
                .HasMany(d => d.Employees)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentID_int);

            //EmployeeModel
            modelBuilder.Entity<EmployeeUser>()
                .HasKey(Employee => Employee.ID_int);

            modelBuilder.Entity<EmployeeUser>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees) 
                .HasForeignKey(e => e.DepartmentID_int);

            modelBuilder.Entity<EmployeeUser>()
                .HasMany(e => e.ServiceFormsSign)
                .WithOne(s => s.Employee)
                .HasForeignKey(s => s.EmployeeID_int);

            modelBuilder.Entity<EmployeeUser>()
               .HasOne(e => e.ChecklistSignature)
               .WithOne(c => c.employee)
               .HasPrincipalKey<ChecklistSignatureModel>(e => e.EmployeeID_int);

            //ServiceOrderModel
            modelBuilder.Entity<ServiceOrderModel>()
                .HasKey(S => new
                {
                    S.OrderID_int,
                    S.CustomerID_int
                });

            modelBuilder.Entity<ServiceOrderModel>()
                .HasOne(s => s.Customer)
                .WithMany(c => c.ServiceOrders)
                .HasPrincipalKey(s => s.CustomerID_int);

            modelBuilder.Entity<ServiceOrderModel>()
                .HasOne(s => s.ServiceOrderServiceform)
                .WithOne(so => so.ServiceOrder)
                .HasPrincipalKey<ServiceOrderServiceformModel>(s => s.OrderID_int);

            //ServiceFormModel
            modelBuilder.Entity<ServiceFormModel>()
                .HasKey(s => new
                {
                    s.FormID_int,
                    s.CustomerID_int
                });

            modelBuilder.Entity<ServiceFormModel>()
                .HasOne(s => s.Customer)
                .WithMany(c => c.ServiceForms)
                .HasPrincipalKey(s => s.CustomerID_int);

            modelBuilder.Entity<ServiceFormModel>()
                .HasOne(s => s.ServiceOrderServiceform)
                .WithOne(sf => sf.serviceForm)
                .HasForeignKey<ServiceOrderServiceformModel>(s => s.OrderID_int);

            modelBuilder.Entity<ServiceFormModel>()
                .HasOne(sf => sf.ServiceFormSign)
                .WithOne(s => s.ServiceForm)
                .HasPrincipalKey<ServiceFormSignModel>(s => s.FormID_int);

            modelBuilder.Entity<ServiceFormModel>()
                .HasOne(s => s.UsedPart)
                .WithMany(p => p.ServiceForms)
                .HasForeignKey(rp => rp.FormID_int);

            modelBuilder.Entity<ServiceFormModel>()
                .HasOne(s => s.ReplacedPartsReturned)
                .WithMany(p => p.ServiceForms)
                .HasForeignKey(rp => rp.FormID_int);

            //ServiceOrderServiceformModel
            modelBuilder.Entity<ServiceOrderServiceformModel>()
                .HasKey(S => new
                {
                    S.OrderID_int,
                    S.FormID_int
                });

            modelBuilder.Entity<ServiceOrderServiceformModel>()
                .HasOne(s => s.ServiceOrder)
                .WithOne(so => so.ServiceOrderServiceform)
                .HasPrincipalKey<ServiceOrderModel>(s => s.OrderID_int);

            modelBuilder.Entity<ServiceOrderServiceformModel>()
                .HasOne(s => s.serviceForm)
                .WithOne(sf => sf.ServiceOrderServiceform)
                .HasPrincipalKey<ServiceFormModel>(s => s.FormID_int);

            //ServiceFormEmployeeModel
            modelBuilder.Entity<ServiceFormEmployeeModel>()
                .HasKey(S => new
                {
                    S.FormID_int,
                    S.EmployeeID_int
                });

            modelBuilder.Entity<ServiceFormEmployeeModel>()
                .HasOne(s => s.Employee)
                .WithMany(e => e.ServiceFormEmployees)
                .HasPrincipalKey(s => s.ID_int);

            modelBuilder.Entity<ServiceFormEmployeeModel>()
                .HasOne(s => s.ServiceForm)
                .WithOne(sf => sf.ServiceFormEmployee)
                .HasPrincipalKey<ServiceFormModel>(s => s.FormID_int);


            //ServiceFormSignModel
            modelBuilder.Entity<ServiceFormSignModel>()
                .HasKey(s =>new
                {
                    s.CustomerID_int,
                    s.FormID_int,
                    s.EmployeeID_int
                });

            modelBuilder.Entity<ServiceFormSignModel>()
                .HasOne(s => s.ServiceForm)
                .WithOne(sf => sf.ServiceFormSign)
                .HasPrincipalKey<ServiceFormModel>(s => s.FormID_int);

            modelBuilder.Entity<ServiceFormSignModel>()
               .HasOne(s => s.Customer)
               .WithMany(c => c.ServiceFormsSign)
               .HasPrincipalKey(s => s.CustomerID_int);

            modelBuilder.Entity<ServiceFormSignModel>()
               .HasOne(e => e.Employee)
               .WithMany(s => s.ServiceFormsSign)
               .HasPrincipalKey(s => s.ID_int);

            //ChecklistModel
            modelBuilder.Entity<ChecklistModel>()
                .HasKey(Checklist => new {
                    Checklist.DocID_str,
                    Checklist.SerialNr_str
                });

            modelBuilder.Entity<ChecklistModel>()
                .HasOne(c => c.product)
                .WithOne(p => p.Checklist)
                .HasPrincipalKey<ProductModel>(s => s.SerialNr_str);

            modelBuilder.Entity<ChecklistModel>()
               .HasOne(cs => cs.ChecklistSignature)
               .WithOne(c => c.Checklist)
               .HasPrincipalKey<ChecklistSignatureModel>(cs => cs.EmployeeID_int);


            //ChecklistSignatureModel
            modelBuilder.Entity<ChecklistSignatureModel>()
                .HasKey(ChecklistSignature => new
                {
                    ChecklistSignature.DocID_str,
                    ChecklistSignature.EmployeeID_int
                });

            modelBuilder.Entity<ChecklistSignatureModel>()
                .HasOne(e => e.employee)
                .WithOne(e => e.ChecklistSignature)
                .HasPrincipalKey<EmployeeUser>(e => e.ID_int);

            modelBuilder.Entity<ChecklistSignatureModel>()
                .HasOne(c => c.Checklist)
                .WithOne(cs => cs.ChecklistSignature)
                .HasPrincipalKey<ChecklistModel>(c => c.DocID_str);


            //Parts
            modelBuilder.Entity<PartsModel>()
                .HasKey(p => p.PartID_int);

            modelBuilder.Entity<PartsModel>()
                .HasOne(p => p.ReplacedPartsReturned)
                .WithMany(rp => rp.Parts)
                .HasForeignKey(rp => rp.PartID_int);

            modelBuilder.Entity<PartsModel>()
                .HasOne(p => p.UsedPart)
                .WithMany(rp => rp.Parts)
                .HasForeignKey(rp => rp.PartID_int);

            //ReplacedParts
            modelBuilder.Entity<ReplacedPartsReturnedModel>()
                .HasKey(p => new
                {
                    p.PartID_int,
                    p.FormID_int
                });

            modelBuilder.Entity<ReplacedPartsReturnedModel>()
                .HasMany(rp => rp.Parts)
                .WithOne(p => p.ReplacedPartsReturned)
                .HasPrincipalKey(rp => rp.PartID_int);

            modelBuilder.Entity<ReplacedPartsReturnedModel>()
                .HasMany(rp => rp.ServiceForms)
                .WithOne(s => s.ReplacedPartsReturned)
                .HasPrincipalKey(rp => rp.FormID_int);

            //UsedParts
            modelBuilder.Entity<UsedPartModel>()
                .HasKey(p => new
                {
                    p.PartID_int,
                    p.FormID_int
                });
            modelBuilder.Entity<UsedPartModel>()
                .HasMany(up => up.Parts)
                .WithOne(p => p.UsedPart)
                .HasPrincipalKey(up => up.PartID_int);

            modelBuilder.Entity<UsedPartModel>()
                .HasMany(rp => rp.ServiceForms)
                .WithOne(s => s.UsedPart)
                .HasPrincipalKey(rp => rp.FormID_int);

            
        }

        public DbSet<AddressModel>? Address { get; set; }
        public DbSet<CustomerModel>? Customer { get; set; }
        public DbSet<WarrantyModel>? Warranty { get; set; }
        public DbSet<ProductModel>? Product { get; set; }
        public DbSet<CustomerProductModel>? CustomerProduct { get; set; }
        public DbSet<DepartmentModel>? Department { get; set; }
        public DbSet<EmployeeUser>? Employees { get; set; }
        public DbSet<ServiceOrderModel>? ServiceOrdre { get; set; }
        public DbSet<ServiceFormModel>? ServiceForm { get; set; }
        public DbSet<ServiceOrderServiceformModel>? ServiceOrderServiceform { get; set; }
        public DbSet<ServiceFormEmployeeModel>? ServiceFormEmployee { get; set; }
        public DbSet<ServiceFormSignModel>? ServiceFormSign { get; set; }
        public DbSet<ChecklistModel>? Checklist { get; set; }
        public DbSet<ChecklistSignatureModel> ChecklistSignature { get; set; }
        public DbSet<PartsModel> Parts { get; set; }
        public DbSet<ReplacedPartsReturnedModel> ReplacedParts { get; set; }
        public DbSet<UsedPartModel> UsedParts { get; set; }
    }
}
