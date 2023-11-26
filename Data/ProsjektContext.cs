using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Prosjekt.Entities;

namespace Prosjekt.Data
{
    public class ProsjektContext : IdentityDbContext<EmployeeUser>
    {
        public ProsjektContext(DbContextOptions<ProsjektContext> options) : base(options) { }

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
                .HasPrincipalKey<ServiceOrderModel>(s => new { s.OrderID_int });

            modelBuilder.Entity<ServiceFormModel>()
                .HasOne(s => s.OrderServiceformModel)
                .WithOne(s => s.serviceForm)
                .HasForeignKey<ServiceOrderServiceformModel>(s => s.FormID_int)
                .IsRequired(false);

            modelBuilder.Entity<ChecklistModel>()
                .HasOne(s => s.OrderServiceformModel)
                .WithOne(s => s.checklist)
                .HasForeignKey<ServiceOrderServiceformModel>(s => s.DocID_str)
                .HasPrincipalKey<ChecklistModel>(c => c.DocID_str)
                .IsRequired(false);

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

            //Legger til employee
            
            modelBuilder.Entity<EmployeeUser>().HasData(
                new EmployeeUser { 
                    Id = "8fc73822-d860-4d38-b11c-a399958e661a",
                    RememberMe =false,
                    FirstName_str = " Jane",
                    LastName_str = "Doe",
                    PhoneNumber = "99453012",
                    UserName= "JaneDoe@mail.com",
                    Email = "JaneDoe@mail.com",
                    NormalizedUserName = "JANEDOE@MAIL.COM", 
                    NormalizedEmail= "JANEDOE@MAIL.COM", 
                    EmailConfirmed =false,
                    PasswordHash= "AQAAAAEAACcQAAAAEJYVFLG47j2WzqsTRkt5gnPc5H8pcOEryz0ZmmgiAdYWuxrqzr1R1ibviQKIkfygbw==",
                    SecurityStamp= "GSYSD4RSRANZJLYPU2KDSQYVSIZEAU46", ConcurrencyStamp= "07c75ea9-5018-4c2a-ac14-07e7c41129b6",
                    PhoneNumberConfirmed=false, TwoFactorEnabled=false, LockoutEnd=null, LockoutEnabled=true, AccessFailedCount=0
                });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "Admin",
                UserId = "8fc73822-d860-4d38-b11c-a399958e661a"
            });


            //Legger til equipment
            modelBuilder.Entity<EquipmentModel>().HasData(
                new EquipmentModel { Id_int = 1, Name_str = "Tommersaks", Availability=true });
            modelBuilder.Entity<EquipmentModel>().HasData(
               new EquipmentModel { Id_int = 2, Name_str = "vinsjhaandtak", Availability = false });
            modelBuilder.Entity<EquipmentModel>().HasData(
               new EquipmentModel { Id_int = 3, Name_str = "Hammer", Availability = false });
            modelBuilder.Entity<EquipmentModel>().HasData(
               new EquipmentModel { Id_int = 4, Name_str = "Skrujern", Availability = true });
            modelBuilder.Entity<EquipmentModel>().HasData(
               new EquipmentModel { Id_int = 5, Name_str = "Drill", Availability = true });
            modelBuilder.Entity<EquipmentModel>().HasData(
               new EquipmentModel { Id_int = 6, Name_str = "Skrutrekker", Availability = false });
            modelBuilder.Entity<EquipmentModel>().HasData(
               new EquipmentModel { Id_int = 7, Name_str = "Stikksag", Availability = false });
            modelBuilder.Entity<EquipmentModel>().HasData(
               new EquipmentModel { Id_int = 8, Name_str = "Slagskrutrekker", Availability = true });
            modelBuilder.Entity<EquipmentModel>().HasData(
               new EquipmentModel { Id_int = 9, Name_str = "Vinkelskrutrekker", Availability = true });
            modelBuilder.Entity<EquipmentModel>().HasData(
               new EquipmentModel { Id_int = 10, Name_str = "Multiverktoy", Availability = true });

            //legger til parts
            modelBuilder.Entity<PartsModel>().HasData(
                new PartsModel { PartID_int=1, EquipmentID_int=8, PartName_str= "Staaltau - 8 mm Metervare", Quantity_available_int= 20});
            modelBuilder.Entity<PartsModel>().HasData(
                new PartsModel { PartID_int = 2, EquipmentID_int = 4, PartName_str = "Gullkjetting m/ krok og tverrpinne", Quantity_available_int = 40 });
            modelBuilder.Entity<PartsModel>().HasData(
                new PartsModel { PartID_int = 3, EquipmentID_int = 1, PartName_str = "Spesialformet m/ stoppeknaster. 160 mm", Quantity_available_int = 10 });
            modelBuilder.Entity<PartsModel>().HasData(
                new PartsModel { PartID_int = 4, EquipmentID_int = 7, PartName_str = "Snarekrok m/ splint", Quantity_available_int = 37 });
            modelBuilder.Entity<PartsModel>().HasData(
                new PartsModel { PartID_int = 5, EquipmentID_int = 9, PartName_str = "Spesialtilpassethurtigkobling", Quantity_available_int = 5 });
            modelBuilder.Entity<PartsModel>().HasData(
                new PartsModel { PartID_int = 6, EquipmentID_int = 10, PartName_str = "Motorsagholder", Quantity_available_int = 13 });
            modelBuilder.Entity<PartsModel>().HasData(
                new PartsModel { PartID_int = 7, EquipmentID_int = 3, PartName_str = "Kasteblokk 2 t", Quantity_available_int = 17 });
            modelBuilder.Entity<PartsModel>().HasData(
                new PartsModel { PartID_int = 8, EquipmentID_int = 6, PartName_str = "Loopekatt", Quantity_available_int = 31 });
            modelBuilder.Entity<PartsModel>().HasData(
                new PartsModel { PartID_int = 9, EquipmentID_int = 2, PartName_str = "Toommersaks", Quantity_available_int = 17 });
            modelBuilder.Entity<PartsModel>().HasData(
                new PartsModel { PartID_int = 10, EquipmentID_int = 5, PartName_str = "Kraftoverf�ringsakselspesialutfoorelse for vinsj", Quantity_available_int = 7 });

            //legger til postal code
            modelBuilder.Entity<PostalCode>().HasData(
                new PostalCode { Postal_Code_str = "4040", City_str="Tromsoo", State_str="Troms og Finnmark", Country_str="Norge" });
            modelBuilder.Entity<PostalCode>().HasData(
                new PostalCode { Postal_Code_str="4630", City_str="Kristiansand", State_str="Agder", Country_str="Norge" });
            modelBuilder.Entity<PostalCode>().HasData(
                new PostalCode { Postal_Code_str="3003", City_str="Stavanger", State_str="Rogaland", Country_str="Norge" });
            modelBuilder.Entity<PostalCode>().HasData(
                new PostalCode { Postal_Code_str="9354", City_str="Molde", State_str="Moore og Romsdal", Country_str="Norge" });
            modelBuilder.Entity<PostalCode>().HasData(
                new PostalCode { Postal_Code_str="7005", City_str = "Bodoo", State_str = "Nordland", Country_str = "Norge" });
            modelBuilder.Entity<PostalCode>().HasData(
                new PostalCode { Postal_Code_str="8911", City_str = "Trondheim", State_str = "Troondelag", Country_str = "Norge" });
            modelBuilder.Entity<PostalCode>().HasData(
                new PostalCode { Postal_Code_str="7070", City_str = "Narvik", State_str = "Nordland", Country_str = "Norge" } );
            modelBuilder.Entity<PostalCode>().HasData(
                new PostalCode { Postal_Code_str="1118", City_str = "Kirkenes", State_str = "Troms og Finnmark", Country_str = "Norge" });
            modelBuilder.Entity<PostalCode>().HasData(
                new PostalCode { Postal_Code_str="9311", City_str = "Svoveer", State_str = "Nordland", Country_str = "Norge" } );
            modelBuilder.Entity<PostalCode>().HasData(
                new PostalCode { Postal_Code_str="7010", City_str = "Harstad", State_str = "Troms og Finnmark", Country_str = "Norge" });

            //Legger til customer
            modelBuilder.Entity<CustomerModel>().HasData(
                new CustomerModel { ID_int= 1, FirstName_str="Dolly", LastName_str="Barrett", Phone_str="+47 4324 0016", Email_str="DollyRoberts@mail.com", Street_Address_str="Almveien 195", Postal_Code_str="4040"});
            modelBuilder.Entity<CustomerModel>().HasData(
                new CustomerModel { ID_int = 2, FirstName_str="Saul", LastName_str="Walsh", Phone_str="+47 437 45 352", Email_str="SaulWalsh@mail.com", Street_Address_str="Trollkleiva 109", Postal_Code_str="4630"});
            modelBuilder.Entity<CustomerModel>().HasData(
                new CustomerModel { ID_int = 3, FirstName_str="Jessie", LastName_str="Vega", Phone_str="+47 914 07 716", Email_str="JessieVega@mail.com", Street_Address_str="Gabbroveien 182", Postal_Code_str="3003" });
            modelBuilder.Entity<CustomerModel>().HasData(
                new CustomerModel { ID_int = 4, FirstName_str="Morris", LastName_str="Carson", Phone_str="+47 998 48 553", Email_str="MorrisCarson@mail.com", Street_Address_str="Nonshaugen 82", Postal_Code_str="9354"});
            modelBuilder.Entity<CustomerModel>().HasData(
                new CustomerModel { ID_int = 5, FirstName_str="Kelly", LastName_str="Stephens", Phone_str="+47 948 97 811", Email_str="KellyStephens@mail.com", Street_Address_str="Bjerkemyrveien 117", Postal_Code_str="7005" });
            modelBuilder.Entity<CustomerModel>().HasData(
                new CustomerModel { ID_int = 6, FirstName_str = "Buddy", LastName_str="Lutz", Phone_str="+47 420 54 744", Email_str="BuddyLutz@mail.com", Street_Address_str="Vaskerelven 62", Postal_Code_str="8911" });
            modelBuilder.Entity<CustomerModel>().HasData(
                new CustomerModel { ID_int = 7, FirstName_str = "Edward", LastName_str = "Medina", Phone_str = "+47 485 78 737", Email_str = "EdwardMedina@mail.com", Street_Address_str = " �rholsveien 230", Postal_Code_str = "7070" });
            modelBuilder.Entity<CustomerModel>().HasData(
                new CustomerModel { ID_int = 8, FirstName_str = "Jody", LastName_str = "Haney", Phone_str = "+47 930 85 126", Email_str = "JodyHaney@mail.com", Street_Address_str = "Bj�rnehiet 62", Postal_Code_str = "1118" });
            modelBuilder.Entity<CustomerModel>().HasData(
                new CustomerModel { ID_int = 9, FirstName_str = "Greg", LastName_str = "Brown", Phone_str = "+47 492 04 498", Email_str = "GregBrown@mail.com", Street_Address_str = "Ryglandveien 138", Postal_Code_str = "9311" });
            modelBuilder.Entity<CustomerModel>().HasData(
                new CustomerModel { ID_int = 10, FirstName_str = "Kris", LastName_str = "Parrish", Phone_str = "+47 954 33 656", Email_str = "KrisParrish@mail.com", Street_Address_str = "Kornbr�tenveien 226", Postal_Code_str = "7010" });

            //Legger til product
            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel {SerialNr_str="IG308011", ProductName_str="Igland 2501", Model_Year=2010, Product_Type_str="En-tromlet" });
            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel {SerialNr_str="IG308231", ProductName_str = "Igland 2501", Model_Year = 2010, Product_Type_str = "En-tromlet" });
            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel {SerialNr_str="IG300622", ProductName_str = "IGLAND 9002 Maxo TLP", Model_Year = 2023, Product_Type_str = "To-tromlet" });
            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel { SerialNr_str = "IG300903", ProductName_str = "IGLAND 52", Model_Year = 2013, Product_Type_str = "En-tromlet" });
            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel { SerialNr_str = "IG300990", ProductName_str = "IGLAND 51", Model_Year = 2019, Product_Type_str = "En-tromlet" });
            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel { SerialNr_str = "IG300052", ProductName_str = "Igland 4501", Model_Year = 2020, Product_Type_str = "En-tromlet" });
            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel { SerialNr_str = "IG300630", ProductName_str = "IGLAND 9002 MAXO", Model_Year = 2015, Product_Type_str = "Vinsjtopp" });
            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel { SerialNr_str = "IG300612", ProductName_str = "IGLAND 6002 Pronto TLP", Model_Year = 2013, Product_Type_str = "Tn-tromlet" });
            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel { SerialNr_str = "IG300491", ProductName_str = "IGLAND 5002 Pento TL", Model_Year = 2005, Product_Type_str = "To-tromlet" });
            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel { SerialNr_str = "IG300191", ProductName_str = "IGLAND 85H", Model_Year = 2020, Product_Type_str = "En-tromlet" });

            //Legger til Warranty
            modelBuilder.Entity<WarrantyModel>().HasData(
                new WarrantyModel { ID_int=1, WarrantyName_str="Lang garanti"});
            modelBuilder.Entity<WarrantyModel>().HasData(
                new WarrantyModel { ID_int=2, WarrantyName_str="Kort garanti"});
            modelBuilder.Entity<WarrantyModel>().HasData(
                new WarrantyModel { ID_int= 3, WarrantyName_str="Lang garanti"});
            modelBuilder.Entity<WarrantyModel>().HasData(
                new WarrantyModel { ID_int= 4, WarrantyName_str="Middels garanti"});
            modelBuilder.Entity<WarrantyModel>().HasData(
                new WarrantyModel { ID_int= 5, WarrantyName_str="Middels garanti"});
            modelBuilder.Entity<WarrantyModel>().HasData(
                new WarrantyModel { ID_int= 6, WarrantyName_str="Lang garanti"});
            modelBuilder.Entity<WarrantyModel>().HasData(
                new WarrantyModel { ID_int=7, WarrantyName_str="Kort garanti"});
            modelBuilder.Entity<WarrantyModel>().HasData(
                new WarrantyModel { ID_int= 8, WarrantyName_str="Lang garanti"});
            modelBuilder.Entity<WarrantyModel>().HasData(
                new WarrantyModel { ID_int= 9, WarrantyName_str="Lang garanti"});
            modelBuilder.Entity<WarrantyModel>().HasData(
                new WarrantyModel { ID_int= 10, WarrantyName_str="Kort garanti"});

            //legg til customer_product
            modelBuilder.Entity<CustomerProductModel>().HasData(
                new CustomerProductModel {SerialNr_str="IG308011", CustomerID_int= 1, WarrantyID_int= 10 });
            modelBuilder.Entity<CustomerProductModel>().HasData(
                new CustomerProductModel { SerialNr_str="IG308231", CustomerID_int = 2, WarrantyID_int = 9 });
            modelBuilder.Entity<CustomerProductModel>().HasData(
                new CustomerProductModel { SerialNr_str = "IG300622", CustomerID_int = 3, WarrantyID_int = 8 });
            modelBuilder.Entity<CustomerProductModel>().HasData(
                new CustomerProductModel { SerialNr_str = "IG300903", CustomerID_int = 4, WarrantyID_int = 7 });
            modelBuilder.Entity<CustomerProductModel>().HasData(
                new CustomerProductModel { SerialNr_str = "IG300990", CustomerID_int = 5, WarrantyID_int = 6 });
            modelBuilder.Entity<CustomerProductModel>().HasData(
                new CustomerProductModel { SerialNr_str = "IG300052", CustomerID_int = 6, WarrantyID_int = 5 });
            modelBuilder.Entity<CustomerProductModel>().HasData(
                new CustomerProductModel { SerialNr_str = "IG300630", CustomerID_int = 7, WarrantyID_int = 4 });
            modelBuilder.Entity<CustomerProductModel>().HasData(
                new CustomerProductModel { SerialNr_str = "IG300612", CustomerID_int = 8, WarrantyID_int = 3 });
            modelBuilder.Entity<CustomerProductModel>().HasData(
                new CustomerProductModel { SerialNr_str = "IG300491", CustomerID_int = 9, WarrantyID_int = 2 });
            modelBuilder.Entity<CustomerProductModel>().HasData(
                new CustomerProductModel { SerialNr_str = "IG300191", CustomerID_int = 10, WarrantyID_int = 1 });

            //Legger til Service_order
            modelBuilder.Entity<ServiceOrderModel>().HasData(
                new ServiceOrderModel {OrderID_int=1, CustomerID_int= 1, CustomerId=1, SerialNr_str= "IG308011",  Order_type_str ="Vedlikehold", Received_Date=new DateOnly(2023,1,1), Description_From_Customer_str="Bytt ut �delagte deler" });
            modelBuilder.Entity<ServiceOrderModel>().HasData(
                new ServiceOrderModel {OrderID_int=2, CustomerID_int= 2, CustomerId=2, SerialNr_str= "IG308231",  Order_type_str ="Sjekk", Received_Date=new DateOnly(2023,2,2), Description_From_Customer_str="Vinsj plutselig stopper" });

            /*
            modelBuilder.Entity<ServiceOrderModel>().HasData(
                new ServiceOrderModel { 2, "Installasjon", "2023-02-02", "Sett opp nytt utstyr" });
            modelBuilder.Entity<ServiceOrderModel>().HasData(
                new ServiceOrderModel { 3, "Reparere", "2023-02-24", "Fiks system som ikke fungerer" });
            modelBuilder.Entity<ServiceOrderModel>().HasData(
                new ServiceOrderModel { 4, "Oppgradering", "2022-04-02", "Forbedre systemytelsen" });
            modelBuilder.Entity<ServiceOrderModel>().HasData(
                new ServiceOrderModel { 5, "Vedlikehold", "2022-04-20", "Rutinesjekk og service" });
            modelBuilder.Entity<ServiceOrderModel>().HasData(
                new ServiceOrderModel { 6, "Reparere", "2021-06-05", "L�s tilkoblingsproblemer" });
            modelBuilder.Entity<ServiceOrderModel>().HasData(
                new ServiceOrderModel { 7, "Oppgradering", "2023-07-06", "Forbedre systemytelsen" });
            modelBuilder.Entity<ServiceOrderModel>().HasData(
                new ServiceOrderModel { 8, "Installasjon", "2023-08-07", "Legg til nye deler" });
            modelBuilder.Entity<ServiceOrderModel>().HasData(
                new ServiceOrderModel { 9, "Vedlikehold", "2023-09-09", "Inspiser og rengj�r"});
            modelBuilder.Entity<ServiceOrderModel>().HasData(
                new ServiceOrderModel {10, "Vedlikehold", "2023-10-17", "Rutinesjekk og service" });
            */
            //Legger til service_form
            
            modelBuilder.Entity<ServiceFormModel>().HasData(
                new ServiceFormModel {FormID_int=200, Repairdescription_str="fikser noe", ServiceCompleted_date=new DateOnly(2023,3,3), AgreedDelivery_date= new DateOnly(2023,4,4),  ProductRecived_date =new DateOnly(2023,4,4), BookedServiceWeek_int=1, ShippingMethod_str="Bil"});
            modelBuilder.Entity<ServiceFormModel>().HasData(
                new ServiceFormModel {FormID_int=201, Repairdescription_str="fikser noe", ServiceCompleted_date=new DateOnly(2023,4,4), AgreedDelivery_date= new DateOnly(2023,5,5),  ProductRecived_date =new DateOnly(2023,5,5), BookedServiceWeek_int=2, ShippingMethod_str="Post"});
            modelBuilder.Entity<ServiceFormModel>().HasData(
                new ServiceFormModel {FormID_int=202, Repairdescription_str="fikser noe", ServiceCompleted_date=new DateOnly(2023,5,5), AgreedDelivery_date= new DateOnly(2023,6,6),  ProductRecived_date =new DateOnly(2023,6,6), BookedServiceWeek_int=3, ShippingMethod_str="Henting"});
            modelBuilder.Entity<ServiceFormModel>().HasData(
                new ServiceFormModel {FormID_int=203, Repairdescription_str="fikser noe", ServiceCompleted_date=new DateOnly(2023,6,6), AgreedDelivery_date= new DateOnly(2023,7,7),  ProductRecived_date =new DateOnly(2023,7,7), BookedServiceWeek_int=4, ShippingMethod_str="bil"});

            
            /*
            modelBuilder.Entity<ServiceFormModel>().HasData(
                new ServiceFormModel { 1, "oodelagt", "2023-01-10", "2023-01-01", "2023-01-02", 1, "med bil" });
            modelBuilder.Entity<ServiceFormModel>().HasData(
                new ServiceFormModel { 2, "justering", "2023-02-11", "2023-02-02", "2023-02-03", 1, "med posten" });
            modelBuilder.Entity<ServiceFormModel>().HasData(
                new ServiceFormModel { 3, "oodelagt", "2022-03-12", "2022-03-03", "2022-03-04", 2, "med bil" });
            modelBuilder.Entity<ServiceFormModel>().HasData(
                new ServiceFormModel { 4, "kontroll", "2022-04-13", "2022-04-04", "2022-04-05", 2, "med bil" });
            modelBuilder.Entity<ServiceFormModel>().HasData(
                new ServiceFormModel { 5, "oodelagt", "2023-05-14", "2023-05-05", "2023-05-06", 2, "med posten" });
            modelBuilder.Entity<ServiceFormModel>().HasData(
                new ServiceFormModel { 6, "kontroll", "2023-06-15", "2023-06-06", "2023-06-07", 4, "med bil" });
            modelBuilder.Entity<ServiceFormModel>().HasData(
                new ServiceFormModel { 7, "justering", "2023-07-16", "2023-07-07", "2023-07-08", 5, "med henting" });
            modelBuilder.Entity<ServiceFormModel>().HasData(
                new ServiceFormModel { 8, "oodelagt", "2022-08-17", "2022-08-08", "2022-08-09", 5, "med henting" });
            modelBuilder.Entity<ServiceFormModel>().HasData(
                new ServiceFormModel { 9, "justering", "2023-09-18", "2023-09-09", "2023-09-10", 6, "med bil" });
            modelBuilder.Entity<ServiceFormModel>().HasData(
                new ServiceFormModel { 10, "kontroll", "2023-10-19", "2023-10-10", "2023-10-11", 7, "med posten" });
            */
            
            /*sjekkliste*/
            modelBuilder.Entity<ChecklistModel>().HasData(
                new ChecklistModel {DocID_str="DOC001", SerialNr_str="IG308011", Type_str="Type_A", Procedure_str="Procedure_1", Starting_Date=new DateOnly(2023,1,1), Prepared_by_str="Taylor Swift", xx_Bar_str="Bar_1", Brake_force="100", Traction_force_Kn="50", Test_winch="tester", comment_str="Noen kommentarer", Hydraulic_cylinder="Ok", Hoses="Defekt", Hydraulic_block="Skiftes", Oil_tank="Skiftes", HOil_gearbox="Ok", Ringe_cylinder_and_replace_seals="Defekt", Brake_cylinder_and_replace_seals="Ok", Clutch_Plate="Skiftes", Check_Brakes="Defekt", Bearing_drum="Ok", PTO_and_storage="Skiftes", Chain_tensioners="Ok", Wire="Ok", Pinion_bearing="Defekt", Wedge_on_sprocket="Ok", Wiring_on_winch="Defekt", Test_radio="Skiftes", EOil_gearbox="Ok"});
            modelBuilder.Entity<ChecklistModel>().HasData(
                new ChecklistModel {DocID_str="DOC002", SerialNr_str="IG308231", Type_str="Type_B", Procedure_str="Procedure_2", Starting_Date=new DateOnly(2023,2,2), Prepared_by_str="Justin Bieber", xx_Bar_str="Bar_2", Brake_force="100", Traction_force_Kn="50", Test_winch="tester", comment_str="Ingen kommentarer", Hydraulic_cylinder="Ok", Hoses="Defekt", Hydraulic_block="Skiftes", Oil_tank="Skiftes", HOil_gearbox="Ok", Ringe_cylinder_and_replace_seals="Defekt", Brake_cylinder_and_replace_seals="Ok", Clutch_Plate="Skiftes", Check_Brakes="Defekt", Bearing_drum="Ok", PTO_and_storage="Skiftes", Chain_tensioners="Ok", Wire="Ok", Pinion_bearing="Defekt", Wedge_on_sprocket="Ok", Wiring_on_winch="Defekt", Test_radio="Skiftes", EOil_gearbox="Ok"});
            modelBuilder.Entity<ChecklistModel>().HasData(
                new ChecklistModel {DocID_str="DOC003", SerialNr_str="IG300622", Type_str="Type_C", Procedure_str="Procedure_1", Starting_Date=new DateOnly(2023,3,3), Prepared_by_str="Terje Gjøsæter", xx_Bar_str="Bar_1", Brake_force="100", Traction_force_Kn="50", Test_winch="tester", comment_str="Få kommentarer", Hydraulic_cylinder="Ok", Hoses="Defekt", Hydraulic_block="Skiftes", Oil_tank="Skiftes", HOil_gearbox="Ok", Ringe_cylinder_and_replace_seals="Defekt", Brake_cylinder_and_replace_seals="Ok", Clutch_Plate="Skiftes", Check_Brakes="Defekt", Bearing_drum="Ok", PTO_and_storage="Skiftes", Chain_tensioners="Ok", Wire="Ok", Pinion_bearing="Defekt", Wedge_on_sprocket="Ok", Wiring_on_winch="Defekt", Test_radio="Skiftes", EOil_gearbox="Ok"});
            modelBuilder.Entity<ChecklistModel>().HasData(
                new ChecklistModel {DocID_str="DOC004", SerialNr_str="IG300903", Type_str="Type_A", Procedure_str="Procedure_3", Starting_Date=new DateOnly(2023,4,4), Prepared_by_str="Sofie Wass", xx_Bar_str="Bar_2", Brake_force="100", Traction_force_Kn="50", Test_winch="tester", comment_str="Mye kommentarer", Hydraulic_cylinder="Ok", Hoses="Defekt", Hydraulic_block="Skiftes", Oil_tank="Skiftes", HOil_gearbox="Ok", Ringe_cylinder_and_replace_seals="Defekt", Brake_cylinder_and_replace_seals="Ok", Clutch_Plate="Skiftes", Check_Brakes="Defekt", Bearing_drum="Ok", PTO_and_storage="Skiftes", Chain_tensioners="Ok", Wire="Ok", Pinion_bearing="Defekt", Wedge_on_sprocket="Ok", Wiring_on_winch="Defekt", Test_radio="Skiftes", EOil_gearbox="Ok"});

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