﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prosjekt.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Address_code_int = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PostalCode_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Address_code_int);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID_int = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Department_name_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID_int);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    SerialNr_str = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductName_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Model_Year = table.Column<DateOnly>(type: "date", nullable: false),
                    Product_Type_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.SerialNr_str);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ReplacedParts",
                columns: table => new
                {
                    PartID_int = table.Column<int>(type: "int", nullable: false),
                    FormID_int = table.Column<int>(type: "int", nullable: false),
                    Quantity_int = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplacedParts", x => new { x.PartID_int, x.FormID_int });
                    table.UniqueConstraint("AK_ReplacedParts_FormID_int", x => x.FormID_int);
                    table.UniqueConstraint("AK_ReplacedParts_PartID_int", x => x.PartID_int);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsedParts",
                columns: table => new
                {
                    PartID_int = table.Column<int>(type: "int", nullable: false),
                    FormID_int = table.Column<int>(type: "int", nullable: false),
                    Quantity_int = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsedParts", x => new { x.PartID_int, x.FormID_int });
                    table.UniqueConstraint("AK_UsedParts_FormID_int", x => x.FormID_int);
                    table.UniqueConstraint("AK_UsedParts_PartID_int", x => x.PartID_int);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Warranty",
                columns: table => new
                {
                    ID_int = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WarrantyName_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WarrantyType_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StartDate_date = table.Column<DateOnly>(type: "date", nullable: false),
                    ExpDate_date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warranty", x => x.ID_int);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID_int = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Street_Address_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address_code_int = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID_int);
                    table.ForeignKey(
                        name: "FK_Customer_Address_Address_code_int",
                        column: x => x.Address_code_int,
                        principalTable: "Address",
                        principalColumn: "Address_code_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID_int = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DepartmentID_int = table.Column<int>(type: "int", nullable: false),
                    FirstName_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Level_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID_int);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentID_int",
                        column: x => x.DepartmentID_int,
                        principalTable: "Department",
                        principalColumn: "DepartmentID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Checklist",
                columns: table => new
                {
                    DocID_str = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SerialNr_str = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Procedure_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Starting_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Prepared_by_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    xx_Bar_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Brake_force = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Traction_force_Kn = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Test_winch = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comment_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hydraulic_cylinder = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hoses = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hydraulic_block = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Oil_tank = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Oil_gearbox_box = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ringe_cylinder_and_replace_seals = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Brake_cylinder_and_replace_seals = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Wiring_on_winch = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Test_radio = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Button_box = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Clutch_Plate = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Brakes = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bearing_drum = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PTO_and_storage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Chain_tensioners = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Wire = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pinion_bearing = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Wedge_on_sprocket = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Product = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checklist", x => new { x.DocID_str, x.SerialNr_str });
                    table.UniqueConstraint("AK_Checklist_DocID_str", x => x.DocID_str);
                    table.UniqueConstraint("AK_Checklist_SerialNr_str", x => x.SerialNr_str);
                    table.ForeignKey(
                        name: "FK_Checklist_Product_Product",
                        column: x => x.Product,
                        principalTable: "Product",
                        principalColumn: "SerialNr_str",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    PartID_int = table.Column<int>(type: "int", nullable: false),
                    PartName_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantity_available_int = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.PartID_int);
                    table.ForeignKey(
                        name: "FK_Parts_ReplacedParts_PartID_int",
                        column: x => x.PartID_int,
                        principalTable: "ReplacedParts",
                        principalColumn: "PartID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parts_UsedParts_PartID_int",
                        column: x => x.PartID_int,
                        principalTable: "UsedParts",
                        principalColumn: "PartID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CustomerProduct",
                columns: table => new
                {
                    SerialNr_str = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerID_int = table.Column<int>(type: "int", nullable: false),
                    WarrantyID_int = table.Column<int>(type: "int", nullable: false),
                    ProductSerialNr_str = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProduct", x => new { x.CustomerID_int, x.SerialNr_str });
                    table.UniqueConstraint("AK_CustomerProduct_SerialNr_str", x => x.SerialNr_str);
                    table.UniqueConstraint("AK_CustomerProduct_WarrantyID_int", x => x.WarrantyID_int);
                    table.ForeignKey(
                        name: "FK_CustomerProduct_Customer_CustomerID_int",
                        column: x => x.CustomerID_int,
                        principalTable: "Customer",
                        principalColumn: "CustomerID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerProduct_Product_ProductSerialNr_str",
                        column: x => x.ProductSerialNr_str,
                        principalTable: "Product",
                        principalColumn: "SerialNr_str",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerProduct_Warranty_WarrantyID_int",
                        column: x => x.WarrantyID_int,
                        principalTable: "Warranty",
                        principalColumn: "ID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ServiceForm",
                columns: table => new
                {
                    FormID_int = table.Column<int>(type: "int", nullable: false),
                    CustomerID_int = table.Column<int>(type: "int", nullable: false),
                    Repairdescription_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServiceCompleted_date = table.Column<DateOnly>(type: "date", nullable: false),
                    AgreedDelivery_date = table.Column<DateOnly>(type: "date", nullable: false),
                    ProductRecived_date = table.Column<DateOnly>(type: "date", nullable: false),
                    BookedServiceWeek_int = table.Column<int>(type: "int", nullable: false),
                    ShippingMethod_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceForm", x => new { x.FormID_int, x.CustomerID_int });
                    table.UniqueConstraint("AK_ServiceForm_FormID_int", x => x.FormID_int);
                    table.ForeignKey(
                        name: "FK_ServiceForm_Customer_CustomerID_int",
                        column: x => x.CustomerID_int,
                        principalTable: "Customer",
                        principalColumn: "CustomerID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceForm_ReplacedParts_FormID_int",
                        column: x => x.FormID_int,
                        principalTable: "ReplacedParts",
                        principalColumn: "FormID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceForm_UsedParts_FormID_int",
                        column: x => x.FormID_int,
                        principalTable: "UsedParts",
                        principalColumn: "FormID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChecklistSignature",
                columns: table => new
                {
                    DocID_str = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployeeID_int = table.Column<int>(type: "int", nullable: false),
                    ChecklistDocID_str = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistSignature", x => new { x.DocID_str, x.EmployeeID_int });
                    table.UniqueConstraint("AK_ChecklistSignature_EmployeeID_int", x => x.EmployeeID_int);
                    table.ForeignKey(
                        name: "FK_ChecklistSignature_Checklist_ChecklistDocID_str",
                        column: x => x.ChecklistDocID_str,
                        principalTable: "Checklist",
                        principalColumn: "DocID_str");
                    table.ForeignKey(
                        name: "FK_ChecklistSignature_Employee_EmployeeID_int",
                        column: x => x.EmployeeID_int,
                        principalTable: "Employee",
                        principalColumn: "ID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ServiceOrdre",
                columns: table => new
                {
                    OrderID_int = table.Column<int>(type: "int", nullable: false),
                    CustomerID_int = table.Column<int>(type: "int", nullable: false),
                    Order_type_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Received_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Description_From_Customer_str = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerProductCustomerID_int = table.Column<int>(type: "int", nullable: false),
                    CustomerProductSerialNr_str = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerProductModelCustomerID_int = table.Column<int>(type: "int", nullable: false),
                    CustomerProductModelSerialNr_str = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceOrdre", x => new { x.OrderID_int, x.CustomerID_int });
                    table.UniqueConstraint("AK_ServiceOrdre_OrderID_int", x => x.OrderID_int);
                    table.ForeignKey(
                        name: "FK_ServiceOrdre_CustomerProduct_CustomerProductCustomerID_int_C~",
                        columns: x => new { x.CustomerProductCustomerID_int, x.CustomerProductSerialNr_str },
                        principalTable: "CustomerProduct",
                        principalColumns: new[] { "CustomerID_int", "SerialNr_str" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceOrdre_CustomerProduct_CustomerProductModelCustomerID_~",
                        columns: x => new { x.CustomerProductModelCustomerID_int, x.CustomerProductModelSerialNr_str },
                        principalTable: "CustomerProduct",
                        principalColumns: new[] { "CustomerID_int", "SerialNr_str" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceOrdre_Customer_CustomerID_int",
                        column: x => x.CustomerID_int,
                        principalTable: "Customer",
                        principalColumn: "CustomerID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ServiceFormEmployee",
                columns: table => new
                {
                    FormID_int = table.Column<int>(type: "int", nullable: false),
                    EmployeeID_int = table.Column<int>(type: "int", nullable: false),
                    Working_Hours_int = table.Column<int>(type: "int", nullable: false),
                    Repair_Description_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServiceFormFormID_int = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceFormEmployee", x => new { x.FormID_int, x.EmployeeID_int });
                    table.ForeignKey(
                        name: "FK_ServiceFormEmployee_Employee_EmployeeID_int",
                        column: x => x.EmployeeID_int,
                        principalTable: "Employee",
                        principalColumn: "ID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceFormEmployee_ServiceForm_ServiceFormFormID_int",
                        column: x => x.ServiceFormFormID_int,
                        principalTable: "ServiceForm",
                        principalColumn: "FormID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ServiceFormSign",
                columns: table => new
                {
                    CustomerID_int = table.Column<int>(type: "int", nullable: false),
                    EmployeeID_int = table.Column<int>(type: "int", nullable: false),
                    FormID_int = table.Column<int>(type: "int", nullable: false),
                    Sign_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    ServiceFormFormID_int = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceFormSign", x => new { x.CustomerID_int, x.FormID_int, x.EmployeeID_int });
                    table.UniqueConstraint("AK_ServiceFormSign_FormID_int", x => x.FormID_int);
                    table.ForeignKey(
                        name: "FK_ServiceFormSign_Customer_CustomerID_int",
                        column: x => x.CustomerID_int,
                        principalTable: "Customer",
                        principalColumn: "CustomerID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceFormSign_Employee_EmployeeID_int",
                        column: x => x.EmployeeID_int,
                        principalTable: "Employee",
                        principalColumn: "ID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceFormSign_ServiceForm_ServiceFormFormID_int",
                        column: x => x.ServiceFormFormID_int,
                        principalTable: "ServiceForm",
                        principalColumn: "FormID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ServiceOrderServiceform",
                columns: table => new
                {
                    OrderID_int = table.Column<int>(type: "int", nullable: false),
                    FormID_int = table.Column<int>(type: "int", nullable: false),
                    ServiceOrderOrderID_int = table.Column<int>(type: "int", nullable: false),
                    CustomerProductCustomerID_int = table.Column<int>(type: "int", nullable: false),
                    CustomerProductSerialNr_str = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceOrderServiceform", x => new { x.OrderID_int, x.FormID_int });
                    table.UniqueConstraint("AK_ServiceOrderServiceform_OrderID_int", x => x.OrderID_int);
                    table.ForeignKey(
                        name: "FK_ServiceOrderServiceform_CustomerProduct_CustomerProductCusto~",
                        columns: x => new { x.CustomerProductCustomerID_int, x.CustomerProductSerialNr_str },
                        principalTable: "CustomerProduct",
                        principalColumns: new[] { "CustomerID_int", "SerialNr_str" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceOrderServiceform_ServiceForm_OrderID_int",
                        column: x => x.OrderID_int,
                        principalTable: "ServiceForm",
                        principalColumn: "FormID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceOrderServiceform_ServiceOrdre_ServiceOrderOrderID_int",
                        column: x => x.ServiceOrderOrderID_int,
                        principalTable: "ServiceOrdre",
                        principalColumn: "OrderID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_Product",
                table: "Checklist",
                column: "Product",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistSignature_ChecklistDocID_str",
                table: "ChecklistSignature",
                column: "ChecklistDocID_str",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Address_code_int",
                table: "Customer",
                column: "Address_code_int");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProduct_ProductSerialNr_str",
                table: "CustomerProduct",
                column: "ProductSerialNr_str",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentID_int",
                table: "Employee",
                column: "DepartmentID_int");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceForm_CustomerID_int",
                table: "ServiceForm",
                column: "CustomerID_int");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceFormEmployee_EmployeeID_int",
                table: "ServiceFormEmployee",
                column: "EmployeeID_int");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceFormEmployee_ServiceFormFormID_int",
                table: "ServiceFormEmployee",
                column: "ServiceFormFormID_int",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceFormSign_EmployeeID_int",
                table: "ServiceFormSign",
                column: "EmployeeID_int");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceFormSign_ServiceFormFormID_int",
                table: "ServiceFormSign",
                column: "ServiceFormFormID_int",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOrderServiceform_CustomerProductCustomerID_int_Custom~",
                table: "ServiceOrderServiceform",
                columns: new[] { "CustomerProductCustomerID_int", "CustomerProductSerialNr_str" });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOrderServiceform_ServiceOrderOrderID_int",
                table: "ServiceOrderServiceform",
                column: "ServiceOrderOrderID_int",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOrdre_CustomerID_int",
                table: "ServiceOrdre",
                column: "CustomerID_int");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOrdre_CustomerProductCustomerID_int_CustomerProductSe~",
                table: "ServiceOrdre",
                columns: new[] { "CustomerProductCustomerID_int", "CustomerProductSerialNr_str" });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOrdre_CustomerProductModelCustomerID_int_CustomerProd~",
                table: "ServiceOrdre",
                columns: new[] { "CustomerProductModelCustomerID_int", "CustomerProductModelSerialNr_str" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChecklistSignature");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropTable(
                name: "ServiceFormEmployee");

            migrationBuilder.DropTable(
                name: "ServiceFormSign");

            migrationBuilder.DropTable(
                name: "ServiceOrderServiceform");

            migrationBuilder.DropTable(
                name: "Checklist");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "ServiceForm");

            migrationBuilder.DropTable(
                name: "ServiceOrdre");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "ReplacedParts");

            migrationBuilder.DropTable(
                name: "UsedParts");

            migrationBuilder.DropTable(
                name: "CustomerProduct");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Warranty");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}