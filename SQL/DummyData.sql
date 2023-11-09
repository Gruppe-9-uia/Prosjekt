-- Department
INSERT INTO Department VALUES(1, "Admin");
INSERT INTO Department VALUES(2, "Mekanisk");
INSERT INTO Department VALUES(3, "Hydraulisk");
INSERT INTO Department VALUES(4, "Elektro");



-- Employees
INSERT INTO Employee (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Password_str, Level_str, DepartmentID_int)
VALUES (1, "Taylor", "Swift", "+47 452 65 333", "TaylorSwift@mail.com", "if51iP6Np", "high", 3);
INSERT INTO Employee (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Password_str, Level_str, DepartmentID_int)
VALUES (2, "Justin", "Bieber", "+47 452 65 444", "JustinBieber@mail.com", "BDXVSRLV9", "middel", 4);
INSERT INTO Employee (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Password_str, Level_str, DepartmentID_int)
VALUES (3, "Snoop", "Dog", "+47 452 65 555", "SnoopDog@mail.com", "yMFEWYvYD", "low", 1);
INSERT INTO Employee (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Password_str, Level_str, DepartmentID_int)
VALUES (4, "Ed", "Sheeran", "+47 452 65 666", "EdSheeran@mail.com", "vOuI0RVTB", "high", 2);
INSERT INTO Employee (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Password_str, Level_str, DepartmentID_int)
VALUES (5, "Julie", "Robin", "+47 452 65 777", "JulieRobin@mail.com", "Ki$Sdio/q", "high", 2;
INSERT INTO Employee (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Password_str, Level_str, DepartmentID_int)
VALUES (6, "Geir", "Hausvik", "+47 452 65 888", "GeirH@mail.com", "d8rOdlCjc", "low", 1);
INSERT INTO Employee (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Password_str, Level_str, DepartmentID_int)
VALUES (7, "Espen", "Limi", "+47 452 65 999", "EspenL@mail.com", "Wg0372MV6", "low", 3);
INSERT INTO Employee (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Password_str, Level_str, DepartmentID_int)
VALUES (8, "Sofie", "Wass", "+47 555 65 333", "SofieW@mail.com", "bx8WOqyzDqS", "middel", 4);
INSERT INTO Employee (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Password_str, Level_str, DepartmentID_int)
VALUES (9, "Terje", "Gjøsæter", "+47 555 65 444", "TerjeG@mail.com", "bx8WOqyzDqS", "high", 3);
INSERT INTO Employee (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Password_str, Level_str, DepartmentID_int)
VALUES (10, "Rania", "El-Gazzar", "+47 555 65 555", "RaniaE@mail.com", "ZA7Q118LU", "high", 1);

-- Customer
INSERT INTO Customer (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Street_Address_str, Postal_Code_str)
VALUES (1, "Dolly", "Barrett", "+47 410 00 001", "DollyRoberts@mail.com", "The Streets 1", "0001");
INSERT INTO Customer (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Street_Address_str, Postal_Code_str)
VALUES (2, "Saul", "Walsh", "+47 410 00 002", "SaulWalsh@mail.com", "The Streets 2", "0002");
INSERT INTO Customer (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Street_Address_str, Postal_Code_str)
VALUES (3, "Jessie", "Vega", "+47 410 00 003", "JessieVega@mail.com", "The Streets 3", "0003");
INSERT INTO Customer (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Street_Address_str, Postal_Code_str)
VALUES (4, "Morris", "Carson", "+47 410 00 004", "MorrisCarson@mail.com", "The Streets 4", "0004");
INSERT INTO Customer (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Street_Address_str, Postal_Code_str)
VALUES (5, "Kelly", "Stephens", "+47 410 00 005", "KellyStephens@mail.com", "The Streets 5", "0005");
INSERT INTO Customer (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Street_Address_str, Postal_Code_str)
VALUES (6, "Buddy", "Lutz", "+47 410 00 006", "BuddyLutz@mail.com", "The Streets 6", "0006");
INSERT INTO Customer (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Street_Address_str, Postal_Code_str)
VALUES (7, "Edward", "Medina", "+47 410 00 007", "EdwardMedina@mail.com", "The Streets 7", "0007");
INSERT INTO Customer (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Street_Address_str, Postal_Code_str)
VALUES (8, "Jody", "Haney", "+47 410 00 008", "JodyHaney@mail.com", "The Streets 8", "0008");
INSERT INTO Customer (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Street_Address_str, Postal_Code_str)
VALUES (9, "Greg", "Brown", "+47 410 00 009", "GregBrown@mail.com", "The Streets 9", "0009");
INSERT INTO Customer (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Street_Address_str, Postal_Code_str)
VALUES (10, "Kris", "Parrish", "+47 410 00 010", "KrisParrish@mail.com", "The Streets 10", "0010");

-- Service_order
INSERT INTO Service_order(OrderID_int, CustomerID_int, Order_type_str, Received_Date, Description_From_Customer_str)
VALUES (1, 101, "Vedlikehold", "01-01-23", "Bytt ut ødelagte deler");
INSERT INTO Service_order(OrderID_int, CustomerID_int, Order_type_str, Received_Date, Description_From_Customer_str)
VALUES (2, 102, "Installasjon", "07-03-23", "Sett opp nytt utstyr");
INSERT INTO Service_order(OrderID_int, CustomerID_int, Order_type_str, Received_Date, Description_From_Customer_str)
VALUES (3, 103, "Reparere", "23-05-23", "Fiks system som ikke fungerer");
INSERT INTO Service_order(OrderID_int, CustomerID_int, Order_type_str, Received_Date, Description_From_Customer_str)
VALUES (4, 104, "Oppgradering", "30-06-23", "Forbedre systemytelsen");
INSERT INTO Service_order(OrderID_int, CustomerID_int, Order_type_str, Received_Date, Description_From_Customer_str)
VALUES (5, 105, "Vedlikehold", "01-07-23", "Rutinesjekk og service");
INSERT INTO Service_order(OrderID_int, CustomerID_int, Order_type_str, Received_Date, Description_From_Customer_str)
VALUES (6, 106, "Reparere", "27-07-23", "Løs tilkoblingsproblemer");
INSERT INTO Service_order(OrderID_int, CustomerID_int, Order_type_str, Received_Date, Description_From_Customer_str)
VALUES (7, 107, "Oppgradering", "30-07-23", "Forbedre systemytelsen");
INSERT INTO Service_order(OrderID_int, CustomerID_int, Order_type_str, Received_Date, Description_From_Customer_str)
VALUES (8, 108, "Installasjon", "05-08-23", "Legg til nye deler");
INSERT INTO Service_order(OrderID_int, CustomerID_int, Order_type_str, Received_Date, Description_From_Customer_str)
VALUES (9, 109, "Vedlikehold", "09-09-23", "Inspiser og rengjør");
INSERT INTO Service_order(OrderID_int, CustomerID_int, Order_type_str, Received_Date, Description_From_Customer_str)
VALUES (10, 110, "Vedlikehold", "11-10-23", "Rutinesjekk og service");

-- Service_form
INSERT INTO  Service_Form (FormID_int, CustomerID_int, Repairdescription_str, ServiceCompleted_date, AgreedDelivery_date, ProductRecived_date,  BookedServiceWeek_int, ShippingMethod_str)
VALUES (1, 123, "ødelagt", 01.01.2023, 02.01.2023, 02.01.2023, 1, "med bil");
INSERT INTO  Service_Form (FormID_int, CustomerID_int, Repairdescription_str, ServiceCompleted_date, AgreedDelivery_date, ProductRecived_date,  BookedServiceWeek_int, ShippingMethod_str)
VALUES (2, 124, "ødelagt", 02.01.2023, 03.01.2023, 03.01.2023, 1, "med bil");
INSERT INTO  Service_Form (FormID_int, CustomerID_int, Repairdescription_str, ServiceCompleted_date, AgreedDelivery_date, ProductRecived_date,  BookedServiceWeek_int, ShippingMethod_str)
VALUES (3, 125, "ødelagt", 03.01.2023, 04.01.2023, 04.01.2023, 1, "med bil");
INSERT INTO  Service_Form (FormID_int, CustomerID_int, Repairdescription_str, ServiceCompleted_date, AgreedDelivery_date, ProductRecived_date,  BookedServiceWeek_int, ShippingMethod_str)
VALUES (4, 126, "ødelagt", 05.01.2023, 06.01.2023, 06.01.2023, 1, "med bil");
INSERT INTO  Service_Form (FormID_int, CustomerID_int, Repairdescription_str, ServiceCompleted_date, AgreedDelivery_date, ProductRecived_date,  BookedServiceWeek_int, ShippingMethod_str)
VALUES (5, 127, "ødelagt", 07.01.2023, 08.01.2023, 08.01.2023, 1, "med bil");
INSERT INTO  Service_Form (FormID_int, CustomerID_int, Repairdescription_str, ServiceCompleted_date, AgreedDelivery_date, ProductRecived_date,  BookedServiceWeek_int, ShippingMethod_str)
VALUES (6, 128, "ødelagt", 09.01.2023, 10.01.2023, 10.01.2023, 1, "med bil");
INSERT INTO  Service_Form (FormID_int, CustomerID_int, Repairdescription_str, ServiceCompleted_date, AgreedDelivery_date, ProductRecived_date,  BookedServiceWeek_int, ShippingMethod_str)
VALUES (7, 129, "ødelagt", 11.01.2023, 12.01.2023, 12.01.2023, 1, "med bil");
INSERT INTO  Service_Form (FormID_int, CustomerID_int, Repairdescription_str, ServiceCompleted_date, AgreedDelivery_date, ProductRecived_date,  BookedServiceWeek_int, ShippingMethod_str)
VALUES (8, 1210, "ødelagt", 13.01.2023, 14.01.2023, 14.01.2023, 1, "med bil");
INSERT INTO  Service_Form (FormID_int, CustomerID_int, Repairdescription_str, ServiceCompleted_date, AgreedDelivery_date, ProductRecived_date,  BookedServiceWeek_int, ShippingMethod_str)
VALUES (9, 1211, "ødelagt", 15.01.2023, 16.01.2023, 16.01.2023, 1, "med bil");
INSERT INTO  Service_Form (FormID_int, CustomerID_int, Repairdescription_str, ServiceCompleted_date, AgreedDelivery_date, ProductRecived_date,  BookedServiceWeek_int, ShippingMethod_str)
VALUES (10, 1212, "ødelagt", 17.01.2023, 18.01.2023, 18.01.2023, 1, "med bil");


-- Parts

INSERT INTO PARTS ID_str, Name_str, Catalog_str)
VALUES (1, "IG200388", "STÅLTAU - 8 mm Metervare", "STÅLTAU")
INSERT INTO PARTS ID_str, Name_str, Catalog_str)
VALUES (2, "IG201201", "Gullkjetting m/ krok og tverrpinne", "SNAREUTSTYR")
INSERT INTO PARTS ID_str, Name_str, Catalog_str)
VALUES (3, "IG201210", "Spesialformet m/ stoppeknaster. 160 mm", "GLIDERE")
INSERT INTO PARTS ID_str, Name_str, Catalog_str)
VALUES (4, "IG200693", "Snarekrok m/ splint", "KROKER",)
INSERT INTO PARTS ID_str, Name_str, Catalog_str)
VALUES (5, "IG143210", "Spesialtilpassethurtigkobling", "DIVERSE UTSTYR")
INSERT INTO PARTS ID_str, Name_str, Catalog_str)
VALUES (6, "IG022151", "Motorsagholder", "DIVERSE UTSTYR")
INSERT INTO PARTS ID_str, Name_str, Catalog_str)
VALUES (7, "IG31326401", "Kasteblokk 2 t", "BLOKKER")
INSERT INTO PARTS ID_str, Name_str, Catalog_str)
VALUES (8, "IG110960", "Løpekatt", "UTSTYR FOR LETT SLEPEBANE")
INSERT INTO PARTS ID_str, Name_str, Catalog_str)
VALUES (9, "G31346355", "Tømmersaks", "TØMMERSAKS")
INSERT INTO PARTS ID_str, Name_str, Catalog_str)
VALUES (10, "IG209100", "Kraftoverføringsakselspesialutførelse for vinsj", "KRAFTOVERFØRINGSAKSEL")

