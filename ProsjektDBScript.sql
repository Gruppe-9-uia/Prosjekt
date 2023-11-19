DROP database ProsjektDB;

CREATE DATABASE IF NOT EXISTS ProsjektDB;
USE ProsjektDB;

CREATE TABLE IF NOT EXISTS Postal_Code(
    Postal_Code_str VARCHAR(50) PRIMARY KEY,
    City_str VARCHAR(50),
    State_str VARCHAR(50),
    Country_str VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS Customer (
    ID_int INTEGER PRIMARY KEY AUTO_INCREMENT,
    FirstName_str VARCHAR(50) NOT NULL,
    LastName_str VARCHAR(50) NOT NULL,
    Phone_str VARCHAR(50) NOT NULL,
    Email_str VARCHAR(50) unique,
    Street_Address_str VARCHAR(50) NOT NULL,
    Postal_Code_str VARCHAR(50) NOT NULL,
    FOREIGN KEY (Postal_Code_str) REFERENCES Postal_Code(Postal_Code_str) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Warranty (
    ID_int INTEGER PRIMARY KEY AUTO_INCREMENT,
    WarrantyName_str VARCHAR(20) NOT NULL,
    StartDate_date date NOT NULL,
    ExpDate_date date NOT NULL
);

CREATE TABLE IF NOT EXISTS Product (
   SerialNr_str VARCHAR(100) PRIMARY KEY,
   ProductName_str VARCHAR(50) NOT NULL,
   Model_Year YEAR NOT NULL,
   Product_Type_str VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS Customer_Product(
   SerialNr_str VARCHAR(100),
   CustomerID_int INTEGER,
   WarrantyID_int INTEGER NOT NULL,
   PRIMARY KEY(SerialNr_str, CustomerID_int),
   FOREIGN KEY(SerialNr_str) REFERENCES Product(SerialNr_str) ON DELETE CASCADE,
   FOREIGN KEY(CustomerID_int) REFERENCES Customer(ID_int) ON DELETE CASCADE,
   FOREIGN KEY(WarrantyID_int) REFERENCES Warranty(ID_int) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Department (
    ID_int INTEGER PRIMARY KEY AUTO_INCREMENT,
    Department_name_str VARCHAR(20) NOT NULL,
    Level_str VARCHAR(20) NOT NULL
);

CREATE TABLE IF NOT EXISTS Employee (
    ID_int INTEGER PRIMARY KEY AUTO_INCREMENT,
    FirstName_str VARCHAR(20) NOT NULL,
    LastName_str VARCHAR(20) NOT NULL,
    Phone_str VARCHAR(15) NOT NULL,
    Email_str VARCHAR(50) UNIQUE NOT NULL,
    Password_Hash VARCHAR(20) NOT NULL,
    DepartmentID_int INTEGER NOT NULL,
    FOREIGN KEY(DepartmentID_int) REFERENCES Department(ID_int) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Service_order (
    OrderID_int INTEGER AUTO_INCREMENT,
    CustomerID_int INTEGER,
    Order_type_str VARCHAR(50) NOT NULL,
    Received_Date DATE NOT NULL,
    Description_From_Customer_str VARCHAR(255),
    PRIMARY KEY(OrderID_int, CustomerID_int),
    FOREIGN KEY(CustomerID_int) REFERENCES Customer_Product(CustomerID_int) ON DELETE CASCADE
);

ALTER TABLE Service_order AUTO_INCREMENT=100;

CREATE TABLE IF NOT EXISTS Service_Form (
    FormID_int INTEGER AUTO_INCREMENT,
    CustomerID_int INTEGER,
    Repairdescription_str VARCHAR(255),
    ServiceCompleted_date DATE NOT NULL,
    AgreedDelivery_date DATE NOT NULL,
    ProductRecived_date DATE NOT NULL,
    BookedServiceWeek_int INTEGER NOT NULL,
    ShippingMethod_str VARCHAR(50) NOT NULL,
    PRIMARY KEY (FormID_int, CustomerID_int),
    FOREIGN KEY(CustomerID_int) REFERENCES Customer(ID_int) ON DELETE CASCADE
);

ALTER TABLE Service_Form AUTO_INCREMENT=200;

CREATE TABLE IF NOT EXISTS Service_Order_Service_form (
    OrderID_int INTEGER,
    FormID_int INTEGER,
    PRIMARY KEY (OrderID_int, FormID_int),
    FOREIGN KEY (OrderID_int) REFERENCES Service_order(OrderID_int) ON DELETE CASCADE,
    FOREIGN KEY (FormID_int) REFERENCES Service_Form(FormID_int) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Service_Form_Employee (
    FormID_int INTEGER,
    EmployeeID_int INTEGER,
    Working_Hours_int INT NOT NULL,
    Repair_Description_str VARCHAR(255),
    PRIMARY KEY (FormID_int, EmployeeID_int),
    FOREIGN KEY (FormID_int) REFERENCES Service_Form(FormID_int) ON DELETE CASCADE,
    FOREIGN KEY (EmployeeID_int) REFERENCES Employee(ID_int) ON DELETE CASCADE
);


CREATE TABLE IF NOT EXISTS Service_Form_Sign (
    CustomerID_int INTEGER,
    EmployeeID_int INTEGER,
    FormID_int INTEGER,
    Sign_Date DATE NOT NULL,
    PRIMARY KEY (CustomerID_int, EmployeeID_int, FormID_int),
    FOREIGN KEY (FormID_int) REFERENCES Service_Form(FormID_int),
    FOREIGN KEY (CustomerID_int) REFERENCES Customer(ID_int) ON DELETE CASCADE,
    FOREIGN KEY (EmployeeID_int) REFERENCES Employee(ID_int) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Checklist (
     DocID_str VARCHAR(50) NOT NULL,
     SerialNr_str VARCHAR(50) NOT NULL,
     Type_str VARCHAR(50),
     Procedure_str VARCHAR(50),
     Starting_Date DATE,
     Prepared_by_str VARCHAR(50),
     xx_Bar_str VARCHAR(50),
     Traction_force_Kn VARCHAR(50),
     Brake_force VARCHAR(50),
     Test_winch VARCHAR(50),
     comment_str VARCHAR(50),
     Hydraulic_cylinder ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     Hydraulic_block ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     Hoses ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     Oil_tank ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     HOil_gearbox ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     Ringe_cylinder_and_replace_seals ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     Brake_cylinder_and_replace_seals ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     Clutch_Plate ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     Check_Brakes ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     Bearing_drum ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     PTO_and_storage ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     Chain_tensioners ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     Wire ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     Pinion_bearing ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     Wedge_on_sprocket ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     Wiring_on_winch ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     Test_radio ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     EOil_gearbox ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     Button_box ENUM('Ok', 'Skiftes', 'Defekt', 'NULL') DEFAULT 'NULL' NOT NULL,
     PRIMARY KEY (DocID_str, SerialNr_str),
     FOREIGN KEY (SerialNr_str ) REFERENCES Product(SerialNr_str) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Checklist_signature (
    DocID_str VARCHAR(50),
    EmployeeID_int int,
    Sign_Date DATE NOT NULL,
    PRIMARY KEY (DocID_str, EmployeeID_int),
    FOREIGN KEY (DocID_str) REFERENCES Checklist(DocID_str) ON DELETE CASCADE,
    FOREIGN KEY (EmployeeID_int) REFERENCES Employee(ID_int) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Equipment (
    EquipmentID_int INTEGER PRIMARY KEY AUTO_INCREMENT,
    Name_str VARCHAR(50) NOT NULL,
    Availability BOOLEAN NOT NULL
);

ALTER TABLE Equipment AUTO_INCREMENT=300;


CREATE TABLE IF NOT EXISTS Parts (
    PartID_int INTEGER PRIMARY KEY AUTO_INCREMENT,
    PartName_str VARCHAR(255) NOT NULL,
    Quantity_available_int INTEGER NOT NULL,
    EquipmentID_int INTEGER,
    FOREIGN KEY (EquipmentID_int) REFERENCES Equipment(EquipmentID_int)
);

ALTER TABLE Parts AUTO_INCREMENT=400;

CREATE TABLE IF NOT EXISTS Replaced_Parts_Returned (
    PartID_int INTEGER,
    FormID_int INTEGER,
    Quantity_int INTEGER NOT NULL,
    PRIMARY KEY (PartID_int, FormID_int),
    FOREIGN KEY (PartID_int) REFERENCES Parts(PartID_int) ON DELETE CASCADE,
    FOREIGN KEY (FormID_int) REFERENCES Service_Form(FormID_int) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Used_Part (
    PartID_int INTEGER,
    FormID_int INTEGER,
    Quantity_used_int INTEGER NOT NULL,
    PRIMARY KEY (PartID_int, FormID_int),
    FOREIGN KEY (PartID_int) REFERENCES Parts(PartID_int) ON DELETE CASCADE,
    FOREIGN KEY (FormID_int) REFERENCES Service_Form(FormID_int) ON DELETE CASCADE
);







