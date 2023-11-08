﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prosjekt.Data;

#nullable disable

namespace Prosjekt.Migrations
{
    [DbContext(typeof(ProsjektContext))]
    [Migration("20231108021234_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Prosjekt.Models.AddressModel", b =>
                {
                    b.Property<int>("Address_code_int")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PostalCode_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("State_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Address_code_int");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Prosjekt.Models.ChecklistModel", b =>
                {
                    b.Property<string>("DocID_str")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SerialNr_str")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Bearing_drum")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Brake_cylinder_and_replace_seals")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Brake_force")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Brakes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Button_box")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Chain_tensioners")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Clutch_Plate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Hoses")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Hydraulic_block")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Oil_gearbox_box")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Oil_tank")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PTO_and_storage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Pinion_bearing")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Prepared_by_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Procedure_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Product")
                        .HasColumnType("int");

                    b.Property<string>("Ringe_cylinder_and_replace_seals")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("Starting_Date")
                        .HasColumnType("date");

                    b.Property<string>("Test_radio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Test_winch")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Traction_force_Kn")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Type_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Wedge_on_sprocket")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Wire")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Wiring_on_winch")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("comment_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("hydraulic_cylinder")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("xx_Bar_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("DocID_str", "SerialNr_str");

                    b.HasAlternateKey("SerialNr_str");

                    b.HasIndex("Product")
                        .IsUnique();

                    b.ToTable("Checklist");
                });

            modelBuilder.Entity("Prosjekt.Models.ChecklistSignatureModel", b =>
                {
                    b.Property<string>("DocID_str")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("EmployeeID_int")
                        .HasColumnType("int");

                    b.Property<string>("ChecklistDocID_str")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("EmployeeID_int1")
                        .HasColumnType("int");

                    b.HasKey("DocID_str", "EmployeeID_int");

                    b.HasAlternateKey("EmployeeID_int");

                    b.HasIndex("ChecklistDocID_str")
                        .IsUnique();

                    b.HasIndex("EmployeeID_int1")
                        .IsUnique();

                    b.ToTable("ChecklistSignature");
                });

            modelBuilder.Entity("Prosjekt.Models.CustomerModel", b =>
                {
                    b.Property<int>("CustomerID_int")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Address_code_int")
                        .HasColumnType("int");

                    b.Property<string>("Email_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Street_Address_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CustomerID_int");

                    b.HasIndex("Address_code_int");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Prosjekt.Models.CustomerProductModel", b =>
                {
                    b.Property<int>("CustomerID_int")
                        .HasColumnType("int");

                    b.Property<string>("SerialNr_str")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("ProductSerialNr_str")
                        .HasColumnType("int");

                    b.Property<int>("WarrantyID_int")
                        .HasColumnType("int");

                    b.Property<int>("WarrantyID_int1")
                        .HasColumnType("int");

                    b.HasKey("CustomerID_int", "SerialNr_str");

                    b.HasAlternateKey("SerialNr_str");

                    b.HasAlternateKey("WarrantyID_int");

                    b.HasIndex("ProductSerialNr_str")
                        .IsUnique();

                    b.HasIndex("WarrantyID_int1")
                        .IsUnique();

                    b.ToTable("CustomerProduct");
                });

            modelBuilder.Entity("Prosjekt.Models.DepartmentModel", b =>
                {
                    b.Property<int>("DepartmentID_int")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Department_name_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("DepartmentID_int");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("Prosjekt.Models.EmployeeModel", b =>
                {
                    b.Property<int>("EmployeeID_int")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DepartmentID_int")
                        .HasColumnType("int");

                    b.Property<string>("Email_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Level_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("EmployeeID_int");

                    b.HasIndex("DepartmentID_int");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Prosjekt.Models.PartsModel", b =>
                {
                    b.Property<int>("PartID_int")
                        .HasColumnType("int");

                    b.Property<string>("PartName_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Quantity_available_int")
                        .HasColumnType("int");

                    b.HasKey("PartID_int");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("Prosjekt.Models.ProductModel", b =>
                {
                    b.Property<int>("SerialNr_str")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("Model_Year")
                        .HasColumnType("date");

                    b.Property<string>("ProductName_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Product_Type_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SerialNr_str");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Prosjekt.Models.ReplacedPartsReturnedModel", b =>
                {
                    b.Property<int>("PartID_int")
                        .HasColumnType("int");

                    b.Property<int>("FormID_int")
                        .HasColumnType("int");

                    b.Property<int>("Quantity_int")
                        .HasColumnType("int");

                    b.HasKey("PartID_int", "FormID_int");

                    b.ToTable("ReplacedParts");
                });

            modelBuilder.Entity("Prosjekt.Models.ServiceFormEmployeeModel", b =>
                {
                    b.Property<int>("FormID_int")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID_int")
                        .HasColumnType("int");

                    b.Property<string>("Repair_Description_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ServiceFormFormID_int")
                        .HasColumnType("int");

                    b.Property<int>("Working_Hours_int")
                        .HasColumnType("int");

                    b.HasKey("FormID_int", "EmployeeID_int");

                    b.HasIndex("EmployeeID_int");

                    b.HasIndex("ServiceFormFormID_int")
                        .IsUnique();

                    b.ToTable("ServiceFormEmployee");
                });

            modelBuilder.Entity("Prosjekt.Models.ServiceFormModel", b =>
                {
                    b.Property<int>("FormID_int")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID_int")
                        .HasColumnType("int");

                    b.Property<DateOnly>("AgreedDelivery_date")
                        .HasColumnType("date");

                    b.Property<int>("BookedServiceWeek_int")
                        .HasColumnType("int");

                    b.Property<DateOnly>("ProductRecived_date")
                        .HasColumnType("date");

                    b.Property<string>("Repairdescription_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("ServiceCompleted_date")
                        .HasColumnType("date");

                    b.Property<string>("ShippingMethod_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("FormID_int", "CustomerID_int");

                    b.HasIndex("CustomerID_int");

                    b.ToTable("ServiceForm");
                });

            modelBuilder.Entity("Prosjekt.Models.ServiceFormSignModel", b =>
                {
                    b.Property<int>("CustomerID_int")
                        .HasColumnType("int");

                    b.Property<int>("FormID_int")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID_int")
                        .HasColumnType("int");

                    b.Property<int>("ServiceFormFormID_int")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Sign_Date")
                        .HasColumnType("date");

                    b.HasKey("CustomerID_int", "FormID_int", "EmployeeID_int");

                    b.HasAlternateKey("FormID_int");

                    b.HasIndex("EmployeeID_int");

                    b.HasIndex("ServiceFormFormID_int")
                        .IsUnique();

                    b.ToTable("ServiceFormSign");
                });

            modelBuilder.Entity("Prosjekt.Models.ServiceOrderModel", b =>
                {
                    b.Property<int>("OrderID_int")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID_int")
                        .HasColumnType("int");

                    b.Property<int>("CustomerProductCustomerID_int")
                        .HasColumnType("int");

                    b.Property<int>("CustomerProductModelCustomerID_int")
                        .HasColumnType("int");

                    b.Property<string>("CustomerProductModelSerialNr_str")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CustomerProductSerialNr_str")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Description_From_Customer_str")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Order_type_str")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateOnly>("Received_Date")
                        .HasColumnType("date");

                    b.HasKey("OrderID_int", "CustomerID_int");

                    b.HasIndex("CustomerID_int");

                    b.HasIndex("CustomerProductCustomerID_int", "CustomerProductSerialNr_str");

                    b.HasIndex("CustomerProductModelCustomerID_int", "CustomerProductModelSerialNr_str");

                    b.ToTable("ServiceOrdre");
                });

            modelBuilder.Entity("Prosjekt.Models.ServiceOrderServiceformModel", b =>
                {
                    b.Property<int>("OrderID_int")
                        .HasColumnType("int");

                    b.Property<int>("FormID_int")
                        .HasColumnType("int");

                    b.Property<int>("CustomerProductCustomerID_int")
                        .HasColumnType("int");

                    b.Property<string>("CustomerProductSerialNr_str")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("ServiceOrderOrderID_int")
                        .HasColumnType("int");

                    b.HasKey("OrderID_int", "FormID_int");

                    b.HasAlternateKey("OrderID_int");

                    b.HasIndex("ServiceOrderOrderID_int")
                        .IsUnique();

                    b.HasIndex("CustomerProductCustomerID_int", "CustomerProductSerialNr_str");

                    b.ToTable("ServiceOrderServiceform");
                });

            modelBuilder.Entity("Prosjekt.Models.UsedPartModel", b =>
                {
                    b.Property<int>("PartID_int")
                        .HasColumnType("int");

                    b.Property<int>("FormID_int")
                        .HasColumnType("int");

                    b.Property<int>("Quantity_int")
                        .HasColumnType("int");

                    b.HasKey("PartID_int", "FormID_int");

                    b.ToTable("UsedParts");
                });

            modelBuilder.Entity("Prosjekt.Models.WarrantyModel", b =>
                {
                    b.Property<int>("WarrantyID_int")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("ExpDate_date")
                        .HasColumnType("date");

                    b.Property<DateOnly>("StartDate_date")
                        .HasColumnType("date");

                    b.Property<string>("WarrantyName_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("WarrantyType_str")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("WarrantyID_int");

                    b.ToTable("Warranty");
                });

            modelBuilder.Entity("Prosjekt.Models.ChecklistModel", b =>
                {
                    b.HasOne("Prosjekt.Models.ProductModel", "product")
                        .WithOne("Checklist")
                        .HasForeignKey("Prosjekt.Models.ChecklistModel", "Product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("Prosjekt.Models.ChecklistSignatureModel", b =>
                {
                    b.HasOne("Prosjekt.Models.ChecklistModel", "Checklist")
                        .WithOne("ChecklistSignature")
                        .HasForeignKey("Prosjekt.Models.ChecklistSignatureModel", "ChecklistDocID_str")
                        .HasPrincipalKey("Prosjekt.Models.ChecklistModel", "DocID_str");

                    b.HasOne("Prosjekt.Models.EmployeeModel", "employee")
                        .WithOne("ChecklistSignature")
                        .HasForeignKey("Prosjekt.Models.ChecklistSignatureModel", "EmployeeID_int1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Checklist");

                    b.Navigation("employee");
                });

            modelBuilder.Entity("Prosjekt.Models.CustomerModel", b =>
                {
                    b.HasOne("Prosjekt.Models.AddressModel", "Address")
                        .WithMany("customers")
                        .HasForeignKey("Address_code_int")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Prosjekt.Models.CustomerProductModel", b =>
                {
                    b.HasOne("Prosjekt.Models.CustomerModel", "Customer")
                        .WithMany("CustomerProducts")
                        .HasForeignKey("CustomerID_int")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prosjekt.Models.ProductModel", "Product")
                        .WithOne("CustomerProduct")
                        .HasForeignKey("Prosjekt.Models.CustomerProductModel", "ProductSerialNr_str")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prosjekt.Models.WarrantyModel", "Warranty")
                        .WithOne("CustomerProduct")
                        .HasForeignKey("Prosjekt.Models.CustomerProductModel", "WarrantyID_int1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Warranty");
                });

            modelBuilder.Entity("Prosjekt.Models.EmployeeModel", b =>
                {
                    b.HasOne("Prosjekt.Models.DepartmentModel", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID_int")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Prosjekt.Models.PartsModel", b =>
                {
                    b.HasOne("Prosjekt.Models.ReplacedPartsReturnedModel", "ReplacedPartsReturned")
                        .WithMany("Parts")
                        .HasForeignKey("PartID_int")
                        .HasPrincipalKey("PartID_int")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prosjekt.Models.UsedPartModel", "UsedPart")
                        .WithMany("Parts")
                        .HasForeignKey("PartID_int")
                        .HasPrincipalKey("PartID_int")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReplacedPartsReturned");

                    b.Navigation("UsedPart");
                });

            modelBuilder.Entity("Prosjekt.Models.ServiceFormEmployeeModel", b =>
                {
                    b.HasOne("Prosjekt.Models.EmployeeModel", "Employee")
                        .WithMany("ServiceFormEmployees")
                        .HasForeignKey("EmployeeID_int")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prosjekt.Models.ServiceFormModel", "ServiceForm")
                        .WithOne("ServiceFormEmployee")
                        .HasForeignKey("Prosjekt.Models.ServiceFormEmployeeModel", "ServiceFormFormID_int")
                        .HasPrincipalKey("Prosjekt.Models.ServiceFormModel", "FormID_int")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("ServiceForm");
                });

            modelBuilder.Entity("Prosjekt.Models.ServiceFormModel", b =>
                {
                    b.HasOne("Prosjekt.Models.CustomerModel", "Customer")
                        .WithMany("ServiceForms")
                        .HasForeignKey("CustomerID_int")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prosjekt.Models.ReplacedPartsReturnedModel", "ReplacedPartsReturned")
                        .WithMany("ServiceForms")
                        .HasForeignKey("FormID_int")
                        .HasPrincipalKey("FormID_int")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prosjekt.Models.UsedPartModel", "UsedPart")
                        .WithMany("ServiceForms")
                        .HasForeignKey("FormID_int")
                        .HasPrincipalKey("FormID_int")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("ReplacedPartsReturned");

                    b.Navigation("UsedPart");
                });

            modelBuilder.Entity("Prosjekt.Models.ServiceFormSignModel", b =>
                {
                    b.HasOne("Prosjekt.Models.CustomerModel", "Customer")
                        .WithMany("ServiceFormsSign")
                        .HasForeignKey("CustomerID_int")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prosjekt.Models.EmployeeModel", "Employee")
                        .WithMany("ServiceFormsSign")
                        .HasForeignKey("EmployeeID_int")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prosjekt.Models.ServiceFormModel", "ServiceForm")
                        .WithOne("ServiceFormSign")
                        .HasForeignKey("Prosjekt.Models.ServiceFormSignModel", "ServiceFormFormID_int")
                        .HasPrincipalKey("Prosjekt.Models.ServiceFormModel", "FormID_int")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("ServiceForm");
                });

            modelBuilder.Entity("Prosjekt.Models.ServiceOrderModel", b =>
                {
                    b.HasOne("Prosjekt.Models.CustomerModel", "Customer")
                        .WithMany("ServiceOrders")
                        .HasForeignKey("CustomerID_int")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prosjekt.Models.CustomerProductModel", "CustomerProduct")
                        .WithMany()
                        .HasForeignKey("CustomerProductCustomerID_int", "CustomerProductSerialNr_str")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prosjekt.Models.CustomerProductModel", "CustomerProductModel")
                        .WithMany()
                        .HasForeignKey("CustomerProductModelCustomerID_int", "CustomerProductModelSerialNr_str")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("CustomerProduct");

                    b.Navigation("CustomerProductModel");
                });

            modelBuilder.Entity("Prosjekt.Models.ServiceOrderServiceformModel", b =>
                {
                    b.HasOne("Prosjekt.Models.ServiceFormModel", "serviceForm")
                        .WithOne("ServiceOrderServiceform")
                        .HasForeignKey("Prosjekt.Models.ServiceOrderServiceformModel", "OrderID_int")
                        .HasPrincipalKey("Prosjekt.Models.ServiceFormModel", "FormID_int")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prosjekt.Models.ServiceOrderModel", "ServiceOrder")
                        .WithOne("ServiceOrderServiceform")
                        .HasForeignKey("Prosjekt.Models.ServiceOrderServiceformModel", "ServiceOrderOrderID_int")
                        .HasPrincipalKey("Prosjekt.Models.ServiceOrderModel", "OrderID_int")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prosjekt.Models.CustomerProductModel", "CustomerProduct")
                        .WithMany()
                        .HasForeignKey("CustomerProductCustomerID_int", "CustomerProductSerialNr_str")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerProduct");

                    b.Navigation("ServiceOrder");

                    b.Navigation("serviceForm");
                });

            modelBuilder.Entity("Prosjekt.Models.AddressModel", b =>
                {
                    b.Navigation("customers");
                });

            modelBuilder.Entity("Prosjekt.Models.ChecklistModel", b =>
                {
                    b.Navigation("ChecklistSignature");
                });

            modelBuilder.Entity("Prosjekt.Models.CustomerModel", b =>
                {
                    b.Navigation("CustomerProducts");

                    b.Navigation("ServiceForms");

                    b.Navigation("ServiceFormsSign");

                    b.Navigation("ServiceOrders");
                });

            modelBuilder.Entity("Prosjekt.Models.DepartmentModel", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Prosjekt.Models.EmployeeModel", b =>
                {
                    b.Navigation("ChecklistSignature")
                        .IsRequired();

                    b.Navigation("ServiceFormEmployees");

                    b.Navigation("ServiceFormsSign");
                });

            modelBuilder.Entity("Prosjekt.Models.ProductModel", b =>
                {
                    b.Navigation("Checklist")
                        .IsRequired();

                    b.Navigation("CustomerProduct")
                        .IsRequired();
                });

            modelBuilder.Entity("Prosjekt.Models.ReplacedPartsReturnedModel", b =>
                {
                    b.Navigation("Parts");

                    b.Navigation("ServiceForms");
                });

            modelBuilder.Entity("Prosjekt.Models.ServiceFormModel", b =>
                {
                    b.Navigation("ServiceFormEmployee")
                        .IsRequired();

                    b.Navigation("ServiceFormSign")
                        .IsRequired();

                    b.Navigation("ServiceOrderServiceform")
                        .IsRequired();
                });

            modelBuilder.Entity("Prosjekt.Models.ServiceOrderModel", b =>
                {
                    b.Navigation("ServiceOrderServiceform")
                        .IsRequired();
                });

            modelBuilder.Entity("Prosjekt.Models.UsedPartModel", b =>
                {
                    b.Navigation("Parts");

                    b.Navigation("ServiceForms");
                });

            modelBuilder.Entity("Prosjekt.Models.WarrantyModel", b =>
                {
                    b.Navigation("CustomerProduct")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
