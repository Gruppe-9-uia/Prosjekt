CREATE DATABASE IF NOT EXISTS ProsjektDB;
USE ProsjektDB;

-- Customer SQL:

CREATE TABLE IF NOT EXISTS Postal_Code(
    Postal_Code_str VARCHAR(50) PRIMARY KEY,
    City_str VARCHAR(50),
    State_str VARCHAR(50),
    Country_str VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS Customer (
    ID_int INTEGER PRIMARY KEY,
    FirstName_str VARCHAR(50),
    LastName_str VARCHAR(50),
    Phone_str VARCHAR(50),
    Email_str VARCHAR(50),
    Street_Address_str VARCHAR(50),
    Postal_Code_str VARCHAR(50),
    FOREIGN KEY (Postal_Code_str) REFERENCES Postal_Code(PostalCode_str)
);

-- ProductWarrantySQL:

CREATE TABLE IF NOT EXISTS Warranty (
    ID_int INTEGER PRIMARY KEY,
    WarrantyName_str VARCHAR(20),
    StartDate_date date,
    ExpDate_date date
);

CREATE TABLE IF NOT EXISTS Product (
   SerialNr_str VARCHAR(100) PRIMARY KEY,
   ProductName_str VARCHAR(50),
   Model_Year YEAR,
   Product_Type_str VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS Customer_Product(
   SerialNr_str VARCHAR(100),
   CustomerID_int INTEGER,
   WarrantyID_int INTEGER,
   PRIMARY KEY(SerialNr_str, CustomerID_int),
   FOREIGN KEY(SerialNr_str) REFERENCES Product(SerialNr_str),
   FOREIGN KEY(CustomerID_int) REFERENCES Customer(ID_int),
   FOREIGN KEY(WarrantyID_int) REFERENCES Warranty(ID_int)
);

-- Department: 

CREATE TABLE IF NOT EXISTS Department (
    ID_int INTEGER PRIMARY KEY,
    Department_name_str VARCHAR(20)
);

-- Employee: 

CREATE TABLE IF NOT EXISTS Employee (
    ID_int INTEGER,
    FirstName_str VARCHAR(20),
    LastName_str VARCHAR(20),
    Phone_str VARCHAR(15),
    Email_str VARCHAR(50),
    Password_str VARCHAR(20),
    Level_str VARCHAR(20),
    DepartmentID_int INTEGER,
    PRIMARY KEY(ID_int),
    FOREIGN KEY(DepartmentID_int) REFERENCES Department(ID_int)
);

-- Service_orderSQL og Service_formSQL:

CREATE TABLE IF NOT EXISTS Service_order (
    OrderID_int INTEGER,
    CustomerID_int INTEGER,
    Order_type_str VARCHAR(50),
    Received_Date DATE,
    Description_From_Customer_str VARCHAR(255),
    PRIMARY KEY(OrderID_int, CustomerID_int),
    FOREIGN KEY(CustomerID_int) REFERENCES Customer_Product(CustomerID_int)
);

CREATE TABLE IF NOT EXISTS Service_Form (
    FormID_int INTEGER,
    CustomerID_int INTEGER,
    Repairdescription_str VARCHAR(255),
    ServiceCompleted_date DATE,
    AgreedDelivery_date DATE,
    ProductRecived_date DATE,
    BookedServiceWeek_int INTEGER,
    ShippingMethod_str VARCHAR(50),
    PRIMARY KEY (FormID_int, CustomerID_int),
    FOREIGN KEY(CustomerID_int) REFERENCES Customer(ID_int)
);

CREATE TABLE IF NOT EXISTS Service_Order_Service_form (
    OrderID_int INTEGER,
    FormID_int INTEGER,
    PRIMARY KEY (OrderID_int, FormID_int),
    FOREIGN KEY (OrderID_int) REFERENCES Service_order(OrderID_int),
    FOREIGN KEY (FormID_int) REFERENCES Service_Form(FormID_int)
);

CREATE TABLE IF NOT EXISTS Service_Form_Employee (
    FormID_int INTEGER,
    EmployeeID_int INTEGER,
    Working_Hours_int INT,
    Repair_Description_str VARCHAR(255),
    PRIMARY KEY (FormID_int, EmployeeID_int),
    FOREIGN KEY (FormID_int) REFERENCES Service_Form(FormID_int),
    FOREIGN KEY (EmployeeID_int) REFERENCES Employee(ID_int)
);


CREATE TABLE IF NOT EXISTS Service_Form_Sign (
    CustomerID_int INTEGER,
    EmployeeID_int INTEGER,
    FormID_int INTEGER,
    Sign_Date DATE,
    PRIMARY KEY (CustomerID_int, EmployeeID_int, FormID_int),
    FOREIGN KEY (FormID_int) REFERENCES Service_Form(FormID_int),
    FOREIGN KEY (CustomerID_int) REFERENCES Customer(ID_int),
    FOREIGN KEY (EmployeeID_int) REFERENCES Employee(ID_int)
);

-- ChecklistSQL:

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
     Hydraulic_cylinder ENUM('Ok', 'Skiftes', 'Defekt'),
     Hoses ENUM('Ok', 'Skiftes', 'Defekt'),
     Oil_tank ENUM('Ok', 'Skiftes', 'Defekt'),
     HOil_gearbox ENUM('Ok', 'Skiftes', 'Defekt'),
     Ringe_cylinder_and_replace_seals ENUM('Ok', 'Skiftes', 'Defekt'),
     Brake_cylinder_and_replace_seals ENUM('Ok', 'Skiftes', 'Defekt'),
     Hydraulic_block('Ok', 'Skiftes', 'Defekt'),,
     Clutch_Plate ENUM('Ok', 'Skiftes', 'Defekt'),
     Check_Brakes ENUM('Ok', 'Skiftes', 'Defekt'),
     Bearing_drum ENUM('Ok', 'Skiftes', 'Defekt'),
     PTO_and_storage ENUM('Ok', 'Skiftes', 'Defekt'),
     Chain_tensioners ENUM('Ok', 'Skiftes', 'Defekt'),
     Wire ENUM('Ok', 'Skiftes', 'Defekt'),
     Pinion_bearing ENUM('Ok', 'Skiftes', 'Defekt'),
     Wedge_on_sprocket enum('Ok', 'Skiftes', 'Defekt'),
     Wiring_on_winch ENUM('Ok', 'Skiftes', 'Defekt'),
     Test_radio ENUM('Ok', 'Skiftes', 'Defekt'),
     EOil_gearbox ENUM('Ok', 'Skiftes', 'Defekt'),
     PRIMARY KEY (DocID_str, SerialNr_str),
     FOREIGN KEY (SerialNr_str ) REFERENCES Product(SerialNr_str)
);

CREATE TABLE IF NOT EXISTS Checklist_signature (
    DocID_str VARCHAR(50) NOT NULL,
    EmployeeID_int int NOT NULL,
    Sign_Date DATE,
    PRIMARY KEY (DocID_str, EmployeeID_int),
    FOREIGN KEY (DocID_str) REFERENCES Checklist(DocID_str),
    FOREIGN KEY (EmployeeID_int) REFERENCES Employee(ID_int)
);

-- PartsSQL:

CREATE TABLE IF NOT EXISTS Parts (
     PartID_int INTEGER PRIMARY KEY,
     PartName_str VARCHAR(255),
     Quantity_available_int INTEGER
);

CREATE TABLE IF NOT EXISTS Replaced_Parts_Returned (
    PartID_int INTEGER,
    FormID_int INTEGER,
    Quantity_int INTEGER,
    PRIMARY KEY (PartID_int, FormID_int),
    FOREIGN KEY (PartID_int) REFERENCES Parts(PartID_int),
    FOREIGN KEY (FormID_int) REFERENCES Service_Form(FormID_int)
);

CREATE TABLE IF NOT EXISTS Used_Part (
    PartID_int INTEGER,
    FormID_int INTEGER,
    Quantity_used_int INTEGER,
    PRIMARY KEY (PartID_int, FormID_int),
    FOREIGN KEY (PartID_int) REFERENCES Parts(PartID_int),
    FOREIGN KEY (FormID_int) REFERENCES Service_Form(FormID_int)
);







