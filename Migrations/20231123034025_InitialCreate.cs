using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                    FirstName_str = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName_str = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
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
                name: "Equipment",
                columns: table => new
                {
                    Id_int = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Availability = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id_int);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Postal_Code",
                columns: table => new
                {
                    Postal_Code_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
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
                    SerialNr_str = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductName_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Model_Year = table.Column<int>(type: "int", nullable: false),
                    Product_Type_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.SerialNr_str);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Service_Form",
                columns: table => new
                {
                    FormID_int = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Repairdescription_str = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServiceCompleted_date = table.Column<DateOnly>(type: "date", nullable: false),
                    AgreedDelivery_date = table.Column<DateOnly>(type: "date", nullable: false),
                    ProductRecived_date = table.Column<DateOnly>(type: "date", nullable: false),
                    BookedServiceWeek_int = table.Column<int>(type: "int", nullable: false),
                    ShippingMethod_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service_Form", x => x.FormID_int);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Warranty",
                columns: table => new
                {
                    ID_int = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WarrantyName_str = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
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
                name: "Parts",
                columns: table => new
                {
                    PartID_int = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PartName_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantity_available_int = table.Column<int>(type: "int", nullable: false),
                    EquipmentID_int = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.PartID_int);
                    table.ForeignKey(
                        name: "FK_Parts_Equipment_EquipmentID_int",
                        column: x => x.EquipmentID_int,
                        principalTable: "Equipment",
                        principalColumn: "Id_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID_int = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Street_Address_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Postal_Code_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
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
                    DocID_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SerialNr_str = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Procedure_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Starting_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Prepared_by_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    xx_Bar_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Brake_force = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Traction_force_Kn = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Test_winch = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comment_str = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hydraulic_cylinder = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hoses = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hydraulic_block = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Oil_tank = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HOil_gearbox = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ringe_cylinder_and_replace_seals = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Brake_cylinder_and_replace_seals = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Clutch_Plate = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Check_Brakes = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bearing_drum = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PTO_and_storage = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Chain_tensioners = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Wire = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pinion_bearing = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Wedge_on_sprocket = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Wiring_on_winch = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Test_radio = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EOil_gearbox = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checklist", x => new { x.DocID_str, x.SerialNr_str });
                    table.UniqueConstraint("AK_Checklist_DocID_str", x => x.DocID_str);
                    table.ForeignKey(
                        name: "FK_Checklist_Product_SerialNr_str",
                        column: x => x.SerialNr_str,
                        principalTable: "Product",
                        principalColumn: "SerialNr_str",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Service_Form_Employee",
                columns: table => new
                {
                    FormID_int = table.Column<int>(type: "int", nullable: false),
                    EmployeeID_int = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Working_Hours_int = table.Column<int>(type: "int", nullable: false),
                    Repair_Description_str = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service_Form_Employee", x => new { x.FormID_int, x.EmployeeID_int });
                    table.ForeignKey(
                        name: "FK_Service_Form_Employee_AspNetUsers_EmployeeID_int",
                        column: x => x.EmployeeID_int,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_Form_Employee_Service_Form_FormID_int",
                        column: x => x.FormID_int,
                        principalTable: "Service_Form",
                        principalColumn: "FormID_int",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Replaced_Parts_Returned_Parts_PartID_int",
                        column: x => x.PartID_int,
                        principalTable: "Parts",
                        principalColumn: "PartID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Replaced_Parts_Returned_Service_Form_FormID_int",
                        column: x => x.FormID_int,
                        principalTable: "Service_Form",
                        principalColumn: "FormID_int",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Used_Parts_Parts_PartID_int",
                        column: x => x.PartID_int,
                        principalTable: "Parts",
                        principalColumn: "PartID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Used_Parts_Service_Form_FormID_int",
                        column: x => x.FormID_int,
                        principalTable: "Service_Form",
                        principalColumn: "FormID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customer_Product",
                columns: table => new
                {
                    SerialNr_str = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerID_int = table.Column<int>(type: "int", nullable: false),
                    WarrantyID_int = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Product", x => new { x.CustomerID_int, x.SerialNr_str });
                    table.UniqueConstraint("AK_Customer_Product_CustomerID_int", x => x.CustomerID_int);
                    table.UniqueConstraint("AK_Customer_Product_SerialNr_str", x => x.SerialNr_str);
                    table.UniqueConstraint("AK_Customer_Product_WarrantyID_int", x => x.WarrantyID_int);
                    table.ForeignKey(
                        name: "FK_Customer_Product_Customer_CustomerID_int",
                        column: x => x.CustomerID_int,
                        principalTable: "Customer",
                        principalColumn: "ID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customer_Product_Product_SerialNr_str",
                        column: x => x.SerialNr_str,
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
                name: "Service_Form_Sign",
                columns: table => new
                {
                    CustomerID_int = table.Column<int>(type: "int", nullable: false),
                    EmployeeID_int = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FormID_int = table.Column<int>(type: "int", nullable: false),
                    Sign_Date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service_Form_Sign", x => new { x.FormID_int, x.EmployeeID_int, x.CustomerID_int });
                    table.ForeignKey(
                        name: "FK_Service_Form_Sign_AspNetUsers_EmployeeID_int",
                        column: x => x.EmployeeID_int,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_Form_Sign_Customer_CustomerID_int",
                        column: x => x.CustomerID_int,
                        principalTable: "Customer",
                        principalColumn: "ID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_Form_Sign_Service_Form_FormID_int",
                        column: x => x.FormID_int,
                        principalTable: "Service_Form",
                        principalColumn: "FormID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Checklist_signature",
                columns: table => new
                {
                    DocID_str = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployeeID_int = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sign_Date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checklist_signature", x => new { x.DocID_str, x.EmployeeID_int });
                    table.ForeignKey(
                        name: "FK_Checklist_signature_AspNetUsers_EmployeeID_int",
                        column: x => x.EmployeeID_int,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checklist_signature_Checklist_DocID_str",
                        column: x => x.DocID_str,
                        principalTable: "Checklist",
                        principalColumn: "DocID_str",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Service_ordre",
                columns: table => new
                {
                    OrderID_int = table.Column<int>(type: "int", nullable: false),
                    CustomerID_int = table.Column<int>(type: "int", nullable: false),
                    SerialNr_str = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Order_type_str = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Received_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Description_From_Customer_str = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service_ordre", x => new { x.OrderID_int, x.CustomerID_int });
                    table.UniqueConstraint("AK_Service_ordre_OrderID_int", x => x.OrderID_int);
                    table.ForeignKey(
                        name: "FK_Service_ordre_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "ID_int",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_ordre_Customer_Product_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer_Product",
                        principalColumn: "CustomerID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Service_Order_Service_form",
                columns: table => new
                {
                    OrderID_int = table.Column<int>(type: "int", nullable: false),
                    FormID_int = table.Column<int>(type: "int", nullable: false),
                    DocID_str = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service_Order_Service_form", x => x.OrderID_int);
                    table.ForeignKey(
                        name: "FK_Service_Order_Service_form_Checklist_DocID_str",
                        column: x => x.DocID_str,
                        principalTable: "Checklist",
                        principalColumn: "DocID_str");
                    table.ForeignKey(
                        name: "FK_Service_Order_Service_form_Service_Form_FormID_int",
                        column: x => x.FormID_int,
                        principalTable: "Service_Form",
                        principalColumn: "FormID_int");
                    table.ForeignKey(
                        name: "FK_Service_Order_Service_form_Service_ordre_OrderID_int",
                        column: x => x.OrderID_int,
                        principalTable: "Service_ordre",
                        principalColumn: "OrderID_int",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "Admin", "admin", "Admin", "ADMIN" },
                    { "Elektro", "Elektro", "Elektro", "ELEKTRO" },
                    { "Hydraulisk", "Hydraulisk", "Hydraulisk", "HYDRAULISK" },
                    { "Mekanisk", "Mekanisk", "Mekanisk", "MEKANISK" }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id_int", "Availability", "Name_str" },
                values: new object[,]
                {
                    { 1, true, "Tommersaks" },
                    { 2, false, "vinsjhaandtak" },
                    { 3, false, "Hammer" },
                    { 4, true, "Skrujern" },
                    { 5, true, "Drill" },
                    { 6, false, "Skrutrekker" },
                    { 7, false, "Stikksag" },
                    { 8, true, "Slagskrutrekker" },
                    { 9, true, "Vinkelskrutrekker" },
                    { 10, true, "Multiverktoy" }
                });

            migrationBuilder.InsertData(
                table: "Postal_Code",
                columns: new[] { "Postal_Code_str", "City_str", "Country_str", "State_str" },
                values: new object[,]
                {
                    { "1118", "Kirkenes", "Norge", "Troms og Finnmark" },
                    { "3003", "Stavanger", "Norge", "Rogaland" },
                    { "4040", "Tromsoo", "Norge", "Troms og Finnmark" },
                    { "4630", "Kristiansand", "Norge", "Agder" },
                    { "7005", "Bodoo", "Norge", "Nordland" },
                    { "7010", "Harstad", "Norge", "Troms og Finnmark" },
                    { "7070", "Narvik", "Norge", "Nordland" },
                    { "8911", "Trondheim", "Norge", "Troondelag" },
                    { "9311", "Svoveer", "Norge", "Nordland" },
                    { "9354", "Molde", "Norge", "Moore og Romsdal" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "SerialNr_str", "Model_Year", "ProductName_str", "Product_Type_str" },
                values: new object[,]
                {
                    { "IG300052", 2020, "Igland 4501", "En-tromlet" },
                    { "IG300191", 2020, "IGLAND 85H", "En-tromlet" },
                    { "IG300491", 2005, "IGLAND 5002 Pento TL", "To-tromlet" },
                    { "IG300612", 2013, "IGLAND 6002 Pronto TLP", "Tn-tromlet" },
                    { "IG300622", 2023, "IGLAND 9002 Maxo TLP", "To-tromlet" },
                    { "IG300630", 2015, "IGLAND 9002 MAXO", "Vinsjtopp" },
                    { "IG300903", 2013, "IGLAND 52", "En-tromlet" },
                    { "IG300990", 2019, "IGLAND 51", "En-tromlet" },
                    { "IG308011", 2010, "Igland 2501", "En-tromlet" },
                    { "IG308231", 2010, "Igland 2501", "En-tromlet" }
                });

            migrationBuilder.InsertData(
                table: "Warranty",
                columns: new[] { "ID_int", "WarrantyName_str" },
                values: new object[,]
                {
                    { 1, "Lang garanti" },
                    { 2, "Kort garanti" },
                    { 3, "Lang garanti" },
                    { 4, "Middels garanti" },
                    { 5, "Middels garanti" },
                    { 6, "Lang garanti" },
                    { 7, "Kort garanti" },
                    { 8, "Lang garanti" },
                    { 9, "Lang garanti" },
                    { 10, "Kort garanti" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "ID_int", "Email_str", "FirstName_str", "LastName_str", "Phone_str", "Postal_Code_str", "Street_Address_str" },
                values: new object[,]
                {
                    { 1, "DollyRoberts@mail.com", "Dolly", "Barrett", "+47 4324 0016", "4040", "Almveien 195" },
                    { 2, "SaulWalsh@mail.com", "Saul", "Walsh", "+47 437 45 352", "4630", "Trollkleiva 109" },
                    { 3, "JessieVega@mail.com", "Jessie", "Vega", "+47 914 07 716", "3003", "Gabbroveien 182" },
                    { 4, "MorrisCarson@mail.com", "Morris", "Carson", "+47 998 48 553", "9354", "Nonshaugen 82" },
                    { 5, "KellyStephens@mail.com", "Kelly", "Stephens", "+47 948 97 811", "7005", "Bjerkemyrveien 117" },
                    { 6, "BuddyLutz@mail.com", "Buddy", "Lutz", "+47 420 54 744", "8911", "Vaskerelven 62" },
                    { 7, "EdwardMedina@mail.com", "Edward", "Medina", "+47 485 78 737", "7070", " Årholsveien 230" },
                    { 8, "JodyHaney@mail.com", "Jody", "Haney", "+47 930 85 126", "1118", "Bjørnehiet 62" },
                    { 9, "GregBrown@mail.com", "Greg", "Brown", "+47 492 04 498", "9311", "Ryglandveien 138" },
                    { 10, "KrisParrish@mail.com", "Kris", "Parrish", "+47 954 33 656", "7010", "Kornbråtenveien 226" }
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "PartID_int", "EquipmentID_int", "PartName_str", "Quantity_available_int" },
                values: new object[,]
                {
                    { 1, 8, "Staaltau - 8 mm Metervare", 20 },
                    { 2, 4, "Gullkjetting m/ krok og tverrpinne", 40 },
                    { 3, 1, "Spesialformet m/ stoppeknaster. 160 mm", 10 },
                    { 4, 7, "Snarekrok m/ splint", 37 },
                    { 5, 9, "Spesialtilpassethurtigkobling", 5 },
                    { 6, 10, "Motorsagholder", 13 },
                    { 7, 3, "Kasteblokk 2 t", 17 },
                    { 8, 6, "Loopekatt", 31 },
                    { 9, 2, "Toommersaks", 17 },
                    { 10, 5, "Kraftoverføringsakselspesialutfoorelse for vinsj", 7 }
                });

            migrationBuilder.InsertData(
                table: "Customer_Product",
                columns: new[] { "CustomerID_int", "SerialNr_str", "WarrantyID_int" },
                values: new object[,]
                {
                    { 1, "IG308011", 10 },
                    { 2, "IG308231", 9 },
                    { 3, "IG300622", 8 },
                    { 4, "IG300903", 7 },
                    { 5, "IG300990", 6 },
                    { 6, "IG300052", 5 },
                    { 7, "IG300630", 4 },
                    { 8, "IG300612", 3 },
                    { 9, "IG300491", 2 },
                    { 10, "IG300191", 1 }
                });

            migrationBuilder.InsertData(
                table: "Service_ordre",
                columns: new[] { "CustomerID_int", "OrderID_int", "CustomerId", "Description_From_Customer_str", "Order_type_str", "Received_Date", "SerialNr_str" },
                values: new object[] { 1, 1, 1, "Bytt ut ødelagte deler", "Vedlikehold", new DateOnly(2023, 1, 1), "IG308011" });

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
                name: "IX_Checklist_SerialNr_str",
                table: "Checklist",
                column: "SerialNr_str",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_signature_DocID_str",
                table: "Checklist_signature",
                column: "DocID_str",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_signature_EmployeeID_int",
                table: "Checklist_signature",
                column: "EmployeeID_int",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Postal_Code_str",
                table: "Customer",
                column: "Postal_Code_str");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_EquipmentID_int",
                table: "Parts",
                column: "EquipmentID_int",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Replaced_Parts_Returned_FormID_int",
                table: "Replaced_Parts_Returned",
                column: "FormID_int",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Service_Form_Employee_EmployeeID_int",
                table: "Service_Form_Employee",
                column: "EmployeeID_int",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Service_Form_Employee_FormID_int",
                table: "Service_Form_Employee",
                column: "FormID_int",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Service_Form_Sign_CustomerID_int",
                table: "Service_Form_Sign",
                column: "CustomerID_int",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Service_Form_Sign_EmployeeID_int",
                table: "Service_Form_Sign",
                column: "EmployeeID_int",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Service_Form_Sign_FormID_int",
                table: "Service_Form_Sign",
                column: "FormID_int",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Service_Order_Service_form_DocID_str",
                table: "Service_Order_Service_form",
                column: "DocID_str",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Service_Order_Service_form_FormID_int",
                table: "Service_Order_Service_form",
                column: "FormID_int",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Service_ordre_CustomerId",
                table: "Service_ordre",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Used_Parts_FormID_int",
                table: "Used_Parts",
                column: "FormID_int",
                unique: true);
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
                name: "Replaced_Parts_Returned");

            migrationBuilder.DropTable(
                name: "Service_Form_Employee");

            migrationBuilder.DropTable(
                name: "Service_Form_Sign");

            migrationBuilder.DropTable(
                name: "Service_Order_Service_form");

            migrationBuilder.DropTable(
                name: "Used_Parts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Checklist");

            migrationBuilder.DropTable(
                name: "Service_ordre");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropTable(
                name: "Service_Form");

            migrationBuilder.DropTable(
                name: "Customer_Product");

            migrationBuilder.DropTable(
                name: "Equipment");

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
