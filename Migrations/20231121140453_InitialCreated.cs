using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prosjekt.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RememberMe = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Level_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Postal_Code",
                columns: table => new
                {
                    Postal_Code_str = table.Column<string>(type: "varchar(255)", nullable: false)
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
                    table.PrimaryKey("PK_Postal_Code", x => x.Postal_Code_str);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    SerialNr_str = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductName_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Model_Year = table.Column<int>(type: "int", nullable: false),
                    Product_Type_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.SerialNr_str);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Replaced_Parts_Returned",
                columns: table => new
                {
                    PartID_int = table.Column<int>(type: "int", nullable: false),
                    FormID_int = table.Column<int>(type: "int", nullable: false),
                    Quantity_int = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replaced_Parts_Returned", x => new { x.PartID_int, x.FormID_int });
                    table.UniqueConstraint("AK_Replaced_Parts_Returned_FormID_int", x => x.FormID_int);
                    table.UniqueConstraint("AK_Replaced_Parts_Returned_PartID_int", x => x.PartID_int);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Used_Parts",
                columns: table => new
                {
                    PartID_int = table.Column<int>(type: "int", nullable: false),
                    FormID_int = table.Column<int>(type: "int", nullable: false),
                    Quantity_int = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Used_Parts", x => new { x.PartID_int, x.FormID_int });
                    table.UniqueConstraint("AK_Used_Parts_FormID_int", x => x.FormID_int);
                    table.UniqueConstraint("AK_Used_Parts_PartID_int", x => x.PartID_int);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Warranty",
                columns: table => new
                {
                    ID_int = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WarrantyName_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warranty", x => x.ID_int);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID_int = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Street_Address_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Postal_Code_str = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID_int);
                    table.ForeignKey(
                        name: "FK_Customer_Postal_Code_Postal_Code_str",
                        column: x => x.Postal_Code_str,
                        principalTable: "Postal_Code",
                        principalColumn: "Postal_Code_str",
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
                    Hydraulic_cylinder = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hoses = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hydraulic_block = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Oil_tank = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HOil_gearbox = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ringe_cylinder_and_replace_seals = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Brake_cylinder_and_replace_seals = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Clutch_Plate = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Check_Brakes = table.Column<string>(type: "longtext", nullable: false)
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
                    Wiring_on_winch = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Test_radio = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EOil_gearbox = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    productSerialNr_str = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checklist", x => new { x.DocID_str, x.SerialNr_str });
                    table.UniqueConstraint("AK_Checklist_DocID_str", x => x.DocID_str);
                    table.UniqueConstraint("AK_Checklist_SerialNr_str", x => x.SerialNr_str);
                    table.ForeignKey(
                        name: "FK_Checklist_Product_productSerialNr_str",
                        column: x => x.productSerialNr_str,
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
                        name: "FK_Parts_Replaced_Parts_Returned_PartID_int",
                        column: x => x.PartID_int,
                        principalTable: "Replaced_Parts_Returned",
                        principalColumn: "PartID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parts_Used_Parts_PartID_int",
                        column: x => x.PartID_int,
                        principalTable: "Used_Parts",
                        principalColumn: "PartID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customer_Product",
                columns: table => new
                {
                    SerialNr_str = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerID_int = table.Column<int>(type: "int", nullable: false),
                    WarrantyID_int = table.Column<int>(type: "int", nullable: false),
                    ProductSerialNr_str = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Product", x => new { x.CustomerID_int, x.SerialNr_str });
                    table.UniqueConstraint("AK_Customer_Product_SerialNr_str", x => x.SerialNr_str);
                    table.UniqueConstraint("AK_Customer_Product_WarrantyID_int", x => x.WarrantyID_int);
                    table.ForeignKey(
                        name: "FK_Customer_Product_Customer_CustomerID_int",
                        column: x => x.CustomerID_int,
                        principalTable: "Customer",
                        principalColumn: "ID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customer_Product_Product_ProductSerialNr_str",
                        column: x => x.ProductSerialNr_str,
                        principalTable: "Product",
                        principalColumn: "SerialNr_str",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customer_Product_Warranty_WarrantyID_int",
                        column: x => x.WarrantyID_int,
                        principalTable: "Warranty",
                        principalColumn: "ID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Service_Form",
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
                    table.PrimaryKey("PK_Service_Form", x => new { x.FormID_int, x.CustomerID_int });
                    table.UniqueConstraint("AK_Service_Form_FormID_int", x => x.FormID_int);
                    table.ForeignKey(
                        name: "FK_Service_Form_Customer_CustomerID_int",
                        column: x => x.CustomerID_int,
                        principalTable: "Customer",
                        principalColumn: "ID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_Form_Replaced_Parts_Returned_FormID_int",
                        column: x => x.FormID_int,
                        principalTable: "Replaced_Parts_Returned",
                        principalColumn: "FormID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_Form_Used_Parts_FormID_int",
                        column: x => x.FormID_int,
                        principalTable: "Used_Parts",
                        principalColumn: "FormID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Checklist_signature",
                columns: table => new
                {
                    DocID_str = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployeeID_int = table.Column<int>(type: "int", nullable: false),
                    ChecklistDocID_str = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    employeeId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checklist_signature", x => new { x.DocID_str, x.EmployeeID_int });
                    table.UniqueConstraint("AK_Checklist_signature_EmployeeID_int", x => x.EmployeeID_int);
                    table.ForeignKey(
                        name: "FK_Checklist_signature_AspNetUsers_employeeId",
                        column: x => x.employeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checklist_signature_Checklist_ChecklistDocID_str",
                        column: x => x.ChecklistDocID_str,
                        principalTable: "Checklist",
                        principalColumn: "DocID_str");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Service_ordre",
                columns: table => new
                {
                    OrderID_int = table.Column<int>(type: "int", nullable: false),
                    CustomerID_int = table.Column<int>(type: "int", nullable: false),
                    Order_type_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Received_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Description_From_Customer_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerProductModelCustomerID_int = table.Column<int>(type: "int", nullable: false),
                    CustomerProductModelSerialNr_str = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service_ordre", x => new { x.OrderID_int, x.CustomerID_int });
                    table.UniqueConstraint("AK_Service_ordre_OrderID_int", x => x.OrderID_int);
                    table.ForeignKey(
                        name: "FK_Service_ordre_Customer_CustomerID_int",
                        column: x => x.CustomerID_int,
                        principalTable: "Customer",
                        principalColumn: "ID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_ordre_Customer_Product_CustomerProductModelCustomerI~",
                        columns: x => new { x.CustomerProductModelCustomerID_int, x.CustomerProductModelSerialNr_str },
                        principalTable: "Customer_Product",
                        principalColumns: new[] { "CustomerID_int", "SerialNr_str" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Service_Form_Employee",
                columns: table => new
                {
                    FormID_int = table.Column<int>(type: "int", nullable: false),
                    EmployeeID_int = table.Column<int>(type: "int", nullable: false),
                    Working_Hours_int = table.Column<int>(type: "int", nullable: false),
                    Repair_Description_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServiceFormFormID_int = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service_Form_Employee", x => new { x.FormID_int, x.EmployeeID_int });
                    table.ForeignKey(
                        name: "FK_Service_Form_Employee_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_Form_Employee_Service_Form_ServiceFormFormID_int",
                        column: x => x.ServiceFormFormID_int,
                        principalTable: "Service_Form",
                        principalColumn: "FormID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Service_Form_Sign",
                columns: table => new
                {
                    CustomerID_int = table.Column<int>(type: "int", nullable: false),
                    EmployeeID_int = table.Column<int>(type: "int", nullable: false),
                    FormID_int = table.Column<int>(type: "int", nullable: false),
                    Sign_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    EmployeeId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServiceFormFormID_int = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service_Form_Sign", x => new { x.CustomerID_int, x.FormID_int, x.EmployeeID_int });
                    table.UniqueConstraint("AK_Service_Form_Sign_FormID_int", x => x.FormID_int);
                    table.ForeignKey(
                        name: "FK_Service_Form_Sign_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Service_Form_Sign_Customer_CustomerID_int",
                        column: x => x.CustomerID_int,
                        principalTable: "Customer",
                        principalColumn: "ID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_Form_Sign_Service_Form_ServiceFormFormID_int",
                        column: x => x.ServiceFormFormID_int,
                        principalTable: "Service_Form",
                        principalColumn: "FormID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Service_Order_Service_form",
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
                    table.PrimaryKey("PK_Service_Order_Service_form", x => new { x.OrderID_int, x.FormID_int });
                    table.UniqueConstraint("AK_Service_Order_Service_form_OrderID_int", x => x.OrderID_int);
                    table.ForeignKey(
                        name: "FK_Service_Order_Service_form_Customer_Product_CustomerProductC~",
                        columns: x => new { x.CustomerProductCustomerID_int, x.CustomerProductSerialNr_str },
                        principalTable: "Customer_Product",
                        principalColumns: new[] { "CustomerID_int", "SerialNr_str" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_Order_Service_form_Service_Form_OrderID_int",
                        column: x => x.OrderID_int,
                        principalTable: "Service_Form",
                        principalColumn: "FormID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_Order_Service_form_Service_ordre_ServiceOrderOrderID~",
                        column: x => x.ServiceOrderOrderID_int,
                        principalTable: "Service_ordre",
                        principalColumn: "OrderID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_productSerialNr_str",
                table: "Checklist",
                column: "productSerialNr_str",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_signature_ChecklistDocID_str",
                table: "Checklist_signature",
                column: "ChecklistDocID_str",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_signature_employeeId",
                table: "Checklist_signature",
                column: "employeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Postal_Code_str",
                table: "Customer",
                column: "Postal_Code_str");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Product_ProductSerialNr_str",
                table: "Customer_Product",
                column: "ProductSerialNr_str",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Service_Form_CustomerID_int",
                table: "Service_Form",
                column: "CustomerID_int");

            migrationBuilder.CreateIndex(
                name: "IX_Service_Form_Employee_EmployeeId",
                table: "Service_Form_Employee",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_Form_Employee_ServiceFormFormID_int",
                table: "Service_Form_Employee",
                column: "ServiceFormFormID_int",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Service_Form_Sign_EmployeeId",
                table: "Service_Form_Sign",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_Form_Sign_ServiceFormFormID_int",
                table: "Service_Form_Sign",
                column: "ServiceFormFormID_int",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Service_Order_Service_form_CustomerProductCustomerID_int_Cus~",
                table: "Service_Order_Service_form",
                columns: new[] { "CustomerProductCustomerID_int", "CustomerProductSerialNr_str" });

            migrationBuilder.CreateIndex(
                name: "IX_Service_Order_Service_form_ServiceOrderOrderID_int",
                table: "Service_Order_Service_form",
                column: "ServiceOrderOrderID_int",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Service_ordre_CustomerID_int",
                table: "Service_ordre",
                column: "CustomerID_int");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ordre_CustomerProductModelCustomerID_int_CustomerPro~",
                table: "Service_ordre",
                columns: new[] { "CustomerProductModelCustomerID_int", "CustomerProductModelSerialNr_str" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Checklist_signature");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropTable(
                name: "Service_Form_Employee");

            migrationBuilder.DropTable(
                name: "Service_Form_Sign");

            migrationBuilder.DropTable(
                name: "Service_Order_Service_form");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Checklist");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Service_Form");

            migrationBuilder.DropTable(
                name: "Service_ordre");

            migrationBuilder.DropTable(
                name: "Replaced_Parts_Returned");

            migrationBuilder.DropTable(
                name: "Used_Parts");

            migrationBuilder.DropTable(
                name: "Customer_Product");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Warranty");

            migrationBuilder.DropTable(
                name: "Postal_Code");
        }
    }
}
