


--  Product
INSERT INTO Product (SerialNr_str, ProductName_str, Model_Year, Product_Type_str)
VALUES
("IG308011", "Igland 2501", "2010","En-tromlet"),
("IG308231", "Igland 2501", "2010","En-tromlet"),
("IG300622", "IGLAND 9002 Maxo TLP", "2023","To-tromlet"),
("IG300902", "IGLAND 52","En-tromlet"),
("IG300052", "Igland 4501", "2020","En-tromlet"),
("IG300630", "IGLAND 9002 MAXO", "2015","Vinsjtopp"),
("IG300612", "IGLAND 6002 Pronto TLP", "2013","Tn-tromlet"),
("IG300491", "IGLAND 5002 Pento TL", "2005", "To-tromlet");

--Warranty
INSERT INTO Warranty (ID_int, WarrantyName_str, WarrantyType_str, StartDate_date, ExpDate_date) 
VALUES
(1, "Lang garanti", "2008-11-09", "2023-11-09"),
(2, "Kort garanti", "2023-12-09", "2028-12-09"),
(3, "Lang garanti", "2013-09-10", "2028-09-10"),
(4, "Middels garanti", "2020-07-02", "2025-07-02"),
(5, "Middels garanti", "2019-11-11", "2024-11-11"),
(6, "Lang garanti", "2020-02-14", "2025-02-14"),
(7, "Kort garanti", "2020-04-01", "2025-04-01"),
(8, "Lang garanti", "2010-03-04", "2025-05-14"),
(9, "Lang garanti", "2014-11-09", "2029-11-09"),
(10, "Kort garanti", "2021-03-15", "2026-03-15");


-- Customer
INSERT INTO Customer (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Street_Address_str, Postal_Code_str)
VALUES
(1, "Dolly", "Barrett", "+47 410 00 001", "DollyRoberts@mail.com", "The Streets 1", "0001"),
(2, "Saul", "Walsh", "+47 410 00 002", "SaulWalsh@mail.com", "The Streets 2", "0002"),
(3, "Jessie", "Vega", "+47 410 00 003", "JessieVega@mail.com", "The Streets 3", "0003"),
(4, "Morris", "Carson", "+47 410 00 004", "MorrisCarson@mail.com", "The Streets 4", "0004"),
(5, "Kelly", "Stephens", "+47 410 00 005", "KellyStephens@mail.com", "The Streets 5", "0005"),
(6, "Buddy", "Lutz", "+47 410 00 006", "BuddyLutz@mail.com", "The Streets 6", "0006"),
(7, "Edward", "Medina", "+47 410 00 007", "EdwardMedina@mail.com", "The Streets 7", "0007"),
(8, "Jody", "Haney", "+47 410 00 008", "JodyHaney@mail.com", "The Streets 8", "0008"),
(9, "Greg", "Brown", "+47 410 00 009", "GregBrown@mail.com", "The Streets 9", "0009"),
(10, "Kris", "Parrish", "+47 410 00 010", "KrisParrish@mail.com", "The Streets 10", "0010");

-- Customer_Product
INSERT INTO Customer_Product (SerialNr_str, CustomerID_int,  WarrantyID_int)
VALUES
("IG308011", 1, 10),
("IG308231", 2, 9),
("IG300622", 3, 8),
("IG300902", 4, 7),
("IG300052", 5, 6),
("IG300630", 6, 5),
("IG300612", 7, 4),
("IG300491", 8, 3),
("IG308011", 9, 2),
("IG300052", 10, 1);
    
-- Department
INSERT INTO Department (ID_int, Department_name_str)
VALUES
(1, "Admin"),
(2, "Mekanisk"),
(3, "Hydraulisk"),
(4, "Elektro");

-- Employees
INSERT INTO Employee (ID_int, FirstName_str, LastName_str, Phone_str, Email_str, Password_str, Level_str, DepartmentID_int)
VALUES 
(1, "Taylor", "Swift", "+47 452 65 333", "TaylorSwift@mail.com", "if51iP6Np", "high", 3),
(2, "Justin", "Bieber", "+47 452 65 444", "JustinBieber@mail.com", "BDXVSRLV9", "middel", 4),
(3, "Snoop", "Dog", "+47 452 65 555", "SnoopDog@mail.com", "yMFEWYvYD", "low", 1),
(4, "Ed", "Sheeran", "+47 452 65 666", "EdSheeran@mail.com", "vOuI0RVTB", "high", 2),
(5, "Julie", "Robin", "+47 452 65 777", "JulieRobin@mail.com", "Ki$Sdio/q", "high", 2),
(6, "Geir", "Hausvik", "+47 452 65 888", "GeirH@mail.com", "d8rOdlCjc", "low", 1),
(7, "Espen", "Limi", "+47 452 65 999", "EspenL@mail.com", "Wg0372MV6", "low", 3),
(8, "Sofie", "Wass", "+47 555 65 333", "SofieW@mail.com", "bx8WOqyzDqS", "middel", 4),
(9, "Terje", "Gjøsæter", "+47 555 65 444", "TerjeG@mail.com", "bx8WOqyzDqS", "high", 3),
(10, "Rania", "El-Gazzar", "+47 555 65 555", "RaniaE@mail.com", "ZA7Q118LU", "high", 1);

-- Postal_Code
INSERT INTO Postal_Code (PostalCode_str, City_str, State_str, Country_str)
VALUES
("0001", "Tromsø", "Troms og Finnmark", "Norge"),
("0002", "Kristiansand", "Agder", "Norge"),
("0003", "Stanavger", "Rogaland", "Norge"),
("0004", "Molde", "Møre og Romsdal", "Norge"),
("0005", "Bodø", "Nordland", "Norge"),
("0006", "Trondheim", "Trøndelag", "Norge"),
("0007", "Narvik", "Nordland", "Norge"),
("0008", "Kirkenes", "Troms og Finnmark", "Norge"),
("0009", "Svovær", "Nordland", "Norge"),
("0010", "Harstad", "Troms og Finnmark", "Norge");

-- Service_order
INSERT INTO Service_order(OrderID_int, CustomerID_int, Order_type_str, Received_Date, Description_From_Customer_str)
VALUES 
(101, 1, "Vedlikehold", "01-01-23", "Bytt ut ødelagte deler"),
(102, 2, "Installasjon", "07-03-23", "Sett opp nytt utstyr"),
(103, 3, "Reparere", "23-05-23", "Fiks system som ikke fungerer"),
(104, 4, "Oppgradering", "30-06-23", "Forbedre systemytelsen"),
(105, 5, "Vedlikehold", "01-07-23", "Rutinesjekk og service"),
(106, 6, "Reparere", "27-07-23", "Løs tilkoblingsproblemer"),
(107, 7, "Oppgradering", "30-07-23", "Forbedre systemytelsen"),
(108, 8, "Installasjon", "05-08-23", "Legg til nye deler"),
(109, 9, "Vedlikehold", "09-09-23", "Inspiser og rengjør"),
(110, 10, "Vedlikehold", "11-10-23", "Rutinesjekk og service");

-- Service_form
INSERT INTO  Service_Form (FormID_int, CustomerID_int, Repairdescription_str, ServiceCompleted_date, AgreedDelivery_date, ProductRecived_date,  BookedServiceWeek_int, ShippingMethod_str)
VALUES 
(123, 1, "Ødelagt", 01.01.2023, 02.01.2023, 02.01.2023, 1, "med bil"),
(124, 2, "Ødelagt", 02.01.2023, 03.01.2023, 03.01.2023, 1, "med bil"),
(125, 3, "Ødelagt", 03.01.2023, 04.01.2023, 04.01.2023, 1, "med bil"),
(126, 4, "Ødelagt", 05.01.2023, 06.01.2023, 06.01.2023, 1, "med bil"),
(127, 5, "Ødelagt", 07.01.2023, 08.01.2023, 08.01.2023, 1, "med bil"),
(128, 6, "Ødelagt", 09.01.2023, 10.01.2023, 10.01.2023, 1, "med bil"),
(129, 7, "Ødelagt", 11.01.2023, 12.01.2023, 12.01.2023, 1, "med bil"),
(1210, 8, "Ødelagt", 13.01.2023, 14.01.2023, 14.01.2023, 1, "med bil"),
(1211, 9, "Ødelagt", 15.01.2023, 16.01.2023, 16.01.2023, 1, "med bil"),
(1212, 10, "Ødelagt", 17.01.2023, 18.01.2023, 18.01.2023, 1, "med bil");

-- Service_Order_Service_form
INSERT INTO Service_Order_Service_form (OrderID_int, FormID_int)
VALUES 
(101, 123),
(102, 124),
(103, 125),
(104, 126),
(105, 127),
(106, 128),
(107, 129),
(108, 1210),
(109, 1211),
(110, 1212);

-- Service_Form_Employee
INSERT INTO Service_Form_Employee (FormID_int, EmployeeID_int, Working_Hours_int, Repair_Description_str)
VALUES
    (123, 1, 67, "Byttet metall bit som holder fast en annen metallbit"),
    (124, 2, 42,  "rotor fast, byttet til ny rotor"),
    (125, 3, 10, "oljet vinsj, fungerer bra nå"),
    (126, 4, 14, "vinsj jobber bra nå"),
    (127, 5, 99, "wire løsner ikke lenger konstand"),
    (128, 6, 666, "skiftet skrue"),
    (129, 7, 64, "skiftet metallbit som holder en annen metallbit"),
    (1210, 8, 26, "skiftet del, og lakkert til bedrift farge"),
    (1211, 9, 73, "gjort ferdig arbeid slik kunden ønsket"),
    (1212, 10, 20, "skiftet ny krok");

-- Parts
-- what the hell is this? 
INSERT INTO Parts (PartID_int, PartName_str, Quantity_available_int)
VALUES 
(111, "STÅLTAU - 8 mm Metervare", 8),
(222, "Gullkjetting m/ krok og tverrpinne", 4),
(333, "Spesialformet m/ stoppeknaster. 160 mm", 8),
(444,   "Snarekrok m/ splint", 20),
(555, "Spesialtilpassethurtigkobling", 50),
(666, "Motorsagholder", 13),
(777, "Kasteblokk 2 t", 100),
(888, "Løpekatt", 45),
(999, "Tømmersaks", 12),
(1010, "Kraftoverføringsakselspesialutførelse for vinsj", 22);

-- Service_Form_Sign
INSERT INTO Service_Form_Sign (CustomerID_int, EmployeeID_int, FormID_int, Sign_Date)
VALUES
(1, 10, 123, 2019-12-01),
(2, 9, 124, 2020-07-21),
(3, 8, 125, 2021-01-26),
(4, 7, 126, 1998-01-27),
(5, 6, 127, 2023-02-02),
(6, 5, 128, 2023-02-10),
(7, 4, 129, 2020-05-10),
(8, 3, 1210, 2021-04-30),
(9, 2, 1211, 2022-11-01),
(10, 1, 1212, 2018-06-25);


-- Checklist
INSERT INTO Checklist (DocID_str, SerialNr_str, Type_str, Procedure_str, Starting_Date, Prepared_by_str, xx_Bar_str, Traction_force_Kn, comment_str, Hydraulic_block, Oil_tank, HOil_gearbox, Ringe_cylinder_and_replace_seals, Cluth_Plate, Check_Brakes, Bearing_drum, PTO_and_storage, Chain_tensioners, Wire, Pinion_bearing, Wedge_on_sprocket, Wiring_on_winch, Pg_test_radio, EOil_gearbox, Button_box)
VALUES
("DOC001", "IG308011", "Type_A", "Procedure_1", "2023-01-01", "Taylor Swift", "Bar_1", "100", "Noen kommentarer", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok"),
("DOC002", "IG308231", "Type_B", "Procedure_2", "2023-02-01", "Justin Bieber", "Bar_2", "150", "Få kommentarer", "Skiftes", "Defekt", "Ok", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Defekt", "Ok", "Defekt", "Skiftes"),
("DOC003", "IG300622", "Type_C", "Procedure_3", "2023-03-01", "Ed Sheeran", "Bar_3", "200", "Ingen kommentar", "Defekt", "Ok", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok"),
("DOC004", "IG300902", "Type_D", "Procedure_2", "2023-04-01", "Julie Robins", "Bar_3", "120", "Mange kommentarer", "Ok", "Defekt", "Ok", "Defekt", "Ok", "Ok", "Defekt", "Skiftes", "Ok", "Skiftes", "Skiftes", "Ok", "Defekt", "Ok", "Ok", "Ok"),
("DOC005", "IG300052", "Type_E", "Procedure_2", "2022-05-01", "Terje Gjøsæter", "Bar_2", "300", "No comments", "Skiftes", "Defekt", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt"),
("DOC006", "IG300630", "Type_F", "Procedure_3", "2022-06-01", "Espen Limi", "Bar_1", "120", "Ingen kommentar", "Ok", "Ok", "Ok", "Defekt", "Skiftes", "Ok", "Skiftes", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Skiftes", "Ok", "Defekt"),
("DOC007", "IG300612", "Type_G", "Procedure_3", "2022-07-01", "Taylor Swift", "Bar_1", "100", "More comments", "Defekt", "Defekt", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Skiftes", "Skiftes", "Ok", "Defekt", "Ok", "Ok", "Defekt"),
("DOC008", "IG300491", "Type_H", "Procedure_1", "2022-08-01", "Justin Bieber", "Bar_3", "50", "Noen kommentarer", "Ok", "Defekt", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Ok", "Ok", "Defekt", "Skiftes", "Ok", "Defekt"),
("DOC009", "IG300902", "Type_I", "Procedure_3", "2022-09-01", "Sofie Wass", "Bar_2", "20", "Noen kommentarer", "Skiftes", "Skiftes", "Ok", "Skiftes", "Skiftes", "Ok", "Skiftes", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt"),
("DOC0010", "IG300491", "Type_J", "Procedure_2", "2022-10-01", "Espen Limi", "Bar_1", "90", "Ingen kommentar", "Defekt", "Defekt", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt");

-- Checklist_signature
INSERT INTO Checklist_signature (DocID_str, EmployeeID_int, Sign_Date)
VALUES
("DOC001", 1, "2022-05-01"),
("DOC002", 2, "2023-01-02"),
("DOC003", 3, "2020-06-03"),
("DOC004", 4, "2022-01-04"),
("DOC005", 5, "2023-08-05"),
("DOC006", 6, "2020-01-06"),
("DOC007", 7, "2023-11-07"),
("DOC008", 8, "2022-01-08"),
("DOC009", 9, "2023-02-09"),
("DOC0010", 10, "2020-03-10");

-- Replaced_Parts_Returned
INSERT INTO Replaced_Parts_Returned (PartID_int, FormID_int, Quantity_int)
VALUES
(111, 123, 4),
(222, 124, 0),
(333, 125, 16),
(444, 126, 2),
(555, 127, 1),
(666, 128, 60),
(777, 129, 5),
(888, 1210, 5),
(999, 1211, 1),
(1010, 1212,2);


-- Used_Part

INSERT INTO Used_Part (PartID_int, FormID_int, Quantity_used_int)
VALUES
(111, 123, 2),
(222, 124, 0),
(333, 125, 3),
(444, 126, 1),
(555, 127, 0),
(666, 128, 59),
(777, 129, 4),
(888, 1210, 4),
(999, 1211, 0),
(1010, 1212,1);
