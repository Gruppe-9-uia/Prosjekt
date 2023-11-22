using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Prosjekt.Entities;

namespace Prosjekt.Data
{
    public class ProsjektContext : IdentityDbContext<EmployeeUser>
    {
        public ProsjektContext(DbContextOptions<ProsjektContext> options) : base (options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Setter opp relasjoner


            //AddressModel
            modelBuilder.Entity<PostalCode>()
                .HasKey(a => a.Postal_Code_str);

            modelBuilder.Entity<PostalCode>()
                .HasMany(a => a.customers)
                .WithOne(c => c.Address)
                .HasForeignKey(a => a.Postal_Code_str);

            //CustomerModel
            modelBuilder.Entity<CustomerModel>()
                .HasKey(Customer => Customer.ID_int);

            modelBuilder.Entity<CustomerModel>()
                .HasOne(c => c.Address)
                .WithMany(a => a.customers)
                .HasForeignKey(c => c.Postal_Code_str);


            modelBuilder.Entity<CustomerModel>()
                .HasMany(c => c.CustomerProducts)
                .WithOne(cp => cp.Customer)
                .HasForeignKey(c => c.CustomerID_int);

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
                .HasForeignKey<CustomerProductModel>(c => c.SerialNr_str);

            modelBuilder.Entity<CustomerProductModel>()
                .HasOne(cp => cp.Customer)
                .WithMany(c => c.CustomerProducts)
                .HasForeignKey(cp => cp.CustomerID_int);

            //EmployeeModel
            modelBuilder.Entity<EmployeeUser>()
                .HasKey(e => e.Id);

            //ServiceOrderModel
            modelBuilder.Entity<ServiceOrderModel>()
                .HasKey(S => new
                {
                    S.OrderID_int,
                    S.CustomerID_int
                });

            modelBuilder.Entity<ServiceOrderModel>()
                .HasOne(cp => cp.CustomerProductModel)
                .WithOne(s => s.ServiceOrders)
                .HasForeignKey<ServiceOrderModel>(c => c.CustomerId)
                .HasPrincipalKey<CustomerProductModel>(c => c.CustomerID_int);

            //Checklist
            modelBuilder.Entity<ChecklistModel>()
                .HasKey(c => new { c.DocID_str, c.SerialNr_str });

            modelBuilder.Entity<ChecklistModel>()
                .HasOne(c => c.product)
                .WithOne(p => p.Checklist)
                .HasForeignKey<ChecklistModel>(c => c.SerialNr_str);

            //Checklist_Signature
            modelBuilder.Entity<ChecklistSignatureModel>()
                .HasKey(c => new { c.DocID_str, c.EmployeeID_int });

            modelBuilder.Entity<EmployeeUser>()
                .HasOne(e => e.ChecklistSignature)
                .WithOne(e => e.employee)
                .HasForeignKey<ChecklistSignatureModel>(c => c.EmployeeID_int)
                .HasPrincipalKey<EmployeeUser>(e => e.Id);

            modelBuilder.Entity<ChecklistSignatureModel>()
              .HasOne(cs => cs.Checklist)
              .WithOne(c => c.ChecklistSignature)
              .HasForeignKey<ChecklistSignatureModel>(cs => cs.DocID_str)
              .HasPrincipalKey<ChecklistModel>(c => c.DocID_str);

            //ServiceFormModel
            modelBuilder.Entity<ServiceFormModel>()
                .HasKey(s => new
                {
                    s.FormID_int,
                });

            //Service_Form_Employee
            modelBuilder.Entity<ServiceFormEmployeeModel>()
                .HasKey(e => new { e.FormID_int, e.EmployeeID_int });

            modelBuilder.Entity<ServiceFormEmployeeModel>()
                .HasOne(s => s.Employee)
                .WithOne(e => e.EmployeeForm)
                .HasForeignKey<ServiceFormEmployeeModel>(s => s.EmployeeID_int);

            modelBuilder.Entity<ServiceFormEmployeeModel>()
                .HasOne(s => s.ServiceForm)
                .WithOne(sf => sf.Employee)
                .HasForeignKey<ServiceFormEmployeeModel>(s => s.FormID_int);

            //Service_Form_Employee
            modelBuilder.Entity<ServiceFormEmployeeModel>()
                .HasKey(e => new { e.FormID_int, e.EmployeeID_int });

            modelBuilder.Entity<EmployeeUser>()
                .HasOne(s => s.EmployeeForm)
                .WithOne(e => e.Employee)
                .HasForeignKey<ServiceFormEmployeeModel>(s => s.EmployeeID_int);

            modelBuilder.Entity<ServiceFormModel>()
                .HasOne(s => s.Employee)
                .WithOne(e => e.ServiceForm)
                .HasForeignKey<ServiceFormEmployeeModel>(s => s.FormID_int);

            //Service_Form_Sign
            modelBuilder.Entity<ServiceFormSignModel>()
                .HasKey(s => new { s.FormID_int, s.EmployeeID_int, s.CustomerID_int });

            modelBuilder.Entity<CustomerModel>()
                .HasOne(c => c.ServiceFormSign)
                .WithOne(s => s.Customer)
                .HasForeignKey<ServiceFormSignModel>(s => s.CustomerID_int);

            modelBuilder.Entity<EmployeeUser>()
                .HasOne(s => s.Sign)
                .WithOne(e => e.Employee)
                .HasForeignKey<ServiceFormSignModel>(s => s.EmployeeID_int);

            modelBuilder.Entity<ServiceFormModel>()
                .HasOne(sf => sf.Sign)
                .WithOne(s => s.ServiceForm)
                .HasForeignKey<ServiceFormSignModel>(s => s.FormID_int);

            //Service_Order_Service_form
            modelBuilder.Entity<ServiceOrderServiceformModel>()
                .HasKey(s => s.OrderID_int);

            modelBuilder.Entity<ServiceOrderModel>()
                .HasOne(s => s.OrderServiceformModel)
                .WithOne(s => s.ServiceOrder)
                .HasForeignKey<ServiceOrderServiceformModel>(s => s.OrderID_int)
                .HasPrincipalKey<ServiceOrderModel>(s => new {s.OrderID_int});

            modelBuilder.Entity<ServiceFormModel>()
                .HasOne(s => s.OrderServiceformModel)
                .WithOne(s => s.serviceForm)
                .HasForeignKey<ServiceOrderServiceformModel>(s => s.FormID_int);

            //Equimenpment
            modelBuilder.Entity<EquipmentModel>()
                .HasKey(e => e.Id_int);

            //Parts
            modelBuilder.Entity<PartsModel>()
                .HasKey(p => p.PartID_int);

            modelBuilder.Entity<EquipmentModel>()
                .HasOne(e => e.Parts)
                .WithOne(p => p.Equipment)
                .HasForeignKey<PartsModel>(p => p.EquipmentID_int);

            //UsedParts
            modelBuilder.Entity<UsedPartModel>()
                .HasKey(p => new
                {
                    p.PartID_int,
                    p.FormID_int
                });

            modelBuilder.Entity<ServiceFormModel>()
                .HasOne(s => s.UsedPart)
                .WithOne(s => s.ServiceForm)
                .HasForeignKey<UsedPartModel>(s => s.FormID_int);

            //ReplacedParts
            modelBuilder.Entity<ReplacedPartsReturnedModel>()
                .HasKey(p => new
                {
                    p.PartID_int,
                    p.FormID_int
                });

            modelBuilder.Entity<ServiceFormModel>()
                .HasOne(s => s.ReplacedPartsReturned)
                .WithOne(s => s.ServiceForm)
                .HasForeignKey<ReplacedPartsReturnedModel>(s => s.FormID_int);
            /*

            //ReplacedParts
            modelBuilder.Entity<ReplacedPartsReturnedModel>()
                .HasKey(p => new
                {
                    p.PartID_int,
                    p.FormID_int
                });

            modelBuilder.Entity<UsedPartModel>()
                .HasOne(u => u.Parts)
                .WithMany(p => p.UsedParts)
                .HasForeignKey(u => u.PartID_int);

            modelBuilder.Entity<ReplacedPartsReturnedModel>()
                .HasOne(u => u.Parts)
                .WithMany(p => p.ReplacedPartsReturned)
                .HasForeignKey(u => u.PartID_int);

            modelBuilder.Entity<PartsModel>()
                .HasOne(p => p.Equipment)
                .WithMany(e => e.Parts)
                .HasForeignKey(u => u.EquipmentID_int);

            
            modelBuilder.Entity<ReplacedPartsReturnedModel>()
                .HasOne(p => p.ServiceForm)
                .WithMany(c => c.ReplacedPartsReturned)
                .HasForeignKey(s => new { s.CustomerID_int, s.SerialNr_str });

            modelBuilder.Entity<UsedPartModel>()
                .HasOne(p => p.ServiceForm)
                .WithMany(c => c.UsedParts)
                .HasForeignKey(s => new { s.CustomerID_int, s.SerialNr_str });
            

            //Service_Order_Service_form
            modelBuilder.Entity<ServiceOrderServiceformModel>()
                .HasKey(s => s.OrderID_int);

            modelBuilder.Entity<ServiceOrderServiceformModel>()
                .HasOne(s => s.ServiceOrder)
                .WithOne(so => so.OrderServiceformModel)
                .HasForeignKey<ServiceOrderServiceformModel>(s => s.OrderID_int);

            modelBuilder.Entity<ServiceOrderServiceformModel>()
                .HasOne(s => s.serviceForm)
                .WithOne(so => so.OrderServiceformModel)
                .HasForeignKey<ServiceOrderServiceformModel>(s => s.FormID_int);



            

            
            */
            // Legger til grunnlegge data
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "Admin", Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = "admin" }
            );

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "Mekanisk", Name = "Mekanisk", NormalizedName = "MEKANISK", ConcurrencyStamp = "Mekanisk" }
            );

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "Hydraulisk", Name = "Hydraulisk", NormalizedName = "HYDRAULISK", ConcurrencyStamp = "Hydraulisk" }
            );

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "Elektro", Name = "Elektro", NormalizedName = "ELEKTRO", ConcurrencyStamp = "Elektro" }
            );
        }

        public DbSet<PostalCode>? Postal_Code { get; set; }
        public DbSet<CustomerModel>? Customer { get; set; }
        public DbSet<WarrantyModel>? Warranty { get; set; }
        public DbSet<ProductModel>? Product { get; set; }
        public DbSet<CustomerProductModel>? Customer_Product { get; set; }
        public DbSet<EmployeeUser>? Employees { get; set; }
        public DbSet<ServiceOrderModel>? Service_ordre { get; set; }
        public DbSet<ServiceFormModel>? Service_Form { get; set; }
        public DbSet<ServiceOrderServiceformModel>? Service_Order_Service_form { get; set; }
        public DbSet<ServiceFormEmployeeModel>? Service_Form_Employee { get; set; }
        public DbSet<ServiceFormSignModel>? Service_Form_Sign { get; set; }
        public DbSet<ChecklistModel>? Checklist { get; set; }
        public DbSet<ChecklistSignatureModel> Checklist_signature { get; set; }
        public DbSet<PartsModel> Parts { get; set; }
        public DbSet<ReplacedPartsReturnedModel> Replaced_Parts_Returned { get; set; }
        public DbSet<UsedPartModel> Used_Parts { get; set; }
        public DbSet<EquipmentModel> Equipment { get; set; }

    }
}
