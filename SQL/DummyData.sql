INSERT INTO Product (SerialNr_str, ProductName_str, Model_Year, Product_Type_str)
VALUES
("IG308011", "Igland 2501", "2010","En-tromlet"),
("IG308231", "Igland 2501", "2010","En-tromlet"),
("IG300622", "IGLAND 9002 Maxo TLP", "2023","To-tromlet"),
("IG300903", "IGLAND 52","2013", "En-tromlet"),
("IG300990", "IGLAND 51", "2019","En-tromlet"),
("IG300052", "Igland 4501", "2020","En-tromlet"),
("IG300630", "IGLAND 9002 MAXO", "2015","Vinsjtopp"),
("IG300612", "IGLAND 6002 Pronto TLP", "2013","Tn-tromlet"),
("IG300491", "IGLAND 5002 Pento TL", "2005", "To-tromlet"),
("IG300191", "IGLAND 85H", "2020", "En-tromlet");

INSERT INTO Warranty (ID_int, WarrantyName_str, StartDate_date, ExpDate_date) VALUES
(1, "Lang garanti", '2008-11-09', '2023-11-09'),
(2, "Kort garanti", '2023-12-09', '2028-12-09'),
(3, "Lang garanti", '2013-09-10', '2028-09-10'),
(4, "Middels garanti", '2020-07-02', '2025-07-02'),
(5, "Middels garanti", '2019-11-11', '2024-11-11'),
(6, "Lang garanti", '2020-02-14', '2025-02-14'),
(7, "Kort garanti", '2020-04-01', '2025-04-01'),
(8, "Lang garanti", '2010-03-04', '2025-05-14'),
(9, "Lang garanti", '2014-11-09', '2029-11-09'),
(10, "Kort garanti", '2021-03-15', '2026-03-15');

INSERT INTO Postal_Code (Postal_Code_str, City_str, State_str, Country_str)
VALUES
    ("0001", "Tromsoo", "Troms og Finnmark", "Norge"),
    ("0002", "Kristiansand", "Agder", "Norge"),
    ("0003", "Stavanger", "Rogaland", "Norge"),
    ("0004", "Molde", "Moore og Romsdal", "Norge"),
    ("0005", "Bodoo", "Nordland", "Norge"),
    ("0006", "Trondheim", "Troondelag", "Norge"),
    ("0007", "Narvik", "Nordland", "Norge"),
    ("0008", "Kirkenes", "Troms og Finnmark", "Norge"),
    ("0009", "Svoveer", "Nordland", "Norge"),
    ("0010", "Harstad", "Troms og Finnmark", "Norge");

INSERT INTO Customer (FirstName_str, LastName_str, Phone_str, Email_str, Street_Address_str, Postal_Code_str)
VALUES
("Dolly", "Barrett", "+47 410 00 001", "DollyRoberts@mail.com", "The Streets 1", "0001"),
("Saul", "Walsh", "+47 410 00 002", "SaulWalsh@mail.com", "The Streets 2", "0002"),
("Jessie", "Vega", "+47 410 00 003", "JessieVega@mail.com", "The Streets 3", "0003"),
("Morris", "Carson", "+47 410 00 004", "MorrisCarson@mail.com", "The Streets 4", "0004"),
("Kelly", "Stephens", "+47 410 00 005", "KellyStephens@mail.com", "The Streets 5", "0005"),
("Buddy", "Lutz", "+47 410 00 006", "BuddyLutz@mail.com", "The Streets 6", "0006"),
("Edward", "Medina", "+47 410 00 007", "EdwardMedina@mail.com", "The Streets 7", "0007"),
("Jody", "Haney", "+47 410 00 008", "JodyHaney@mail.com", "The Streets 8", "0008"),
("Greg", "Brown", "+47 410 00 009", "GregBrown@mail.com", "The Streets 9", "0009"),
("Kris", "Parrish", "+47 410 00 010", "KrisParrish@mail.com", "The Streets 10", "0010");

INSERT INTO Customer_Product (SerialNr_str, CustomerID_int,  WarrantyID_int)
VALUES
("IG308011", 1, 10),
("IG308231", 2, 9),
("IG300622", 3, 8),
("IG300903", 4, 7),
("IG300990", 5, 6),
("IG300052", 6, 5),
("IG300630", 7, 4),
("IG300612", 8, 3),
("IG300491", 9, 2),
("IG300191", 10, 1);

    
INSERT INTO Department (ID_int, Department_name_str, Level_str)
VALUES
(1, "Admin" , "High"),
(2, "Mekanisk", "Middels"),
(3, "Hydraulisk", "Middels" ),
(4, "Elektro", "Middels");

INSERT INTO Employee (FirstName_str, LastName_str, Phone_str, Email_str, Password_Hash, DepartmentID_int)
VALUES 
("Taylor", "Swift", "+47 452 65 333", "TaylorSwift@mail.com", "if51iP6Np", 3),
("Justin", "Bieber", "+47 452 65 444", "JustinBieber@mail.com", "BDXVSRLV9", 4),
("Snoop", "Dog", "+47 452 65 555", "SnoopDog@mail.com", "yMFEWYvYD", 1),
("Ed", "Sheeran", "+47 452 65 666", "EdSheeran@mail.com", "vOuI0RVTB", 2),
("Julie", "Robin", "+47 452 65 777", "JulieRobin@mail.com", "Ki$Sdio/q", 2),
("Geir", "Hausvik", "+47 452 65 888", "GeirH@mail.com", "d8rOdlCjc", 1),
("Espen", "Limi", "+47 452 65 999", "EspenL@mail.com", "Wg0372MV6", 3),
("Sofie", "Wass", "+47 555 65 333", "SofieW@mail.com", "bx8WOqyzDqS", 4),
("Terje", "Gjøsæter", "+47 555 65 444", "TerjeG@mail.com", "bx8WOqyzDqS", 3),
("Rania", "El-Gazzar", "+47 555 65 555", "RaniaE@mail.com", "ZA7Q118LU", 1);


-- Service_order - kjører ikke
INSERT INTO Service_order(CustomerID_int, Order_type_str, Received_Date, Description_From_Customer_str)
VALUES 
(1, "Vedlikehold", "2023-01-01", "Bytt ut ødelagte deler"),
(2, "Installasjon", "2023-02-02", "Sett opp nytt utstyr"),
(3, "Reparere", "2023-02-24", "Fiks system som ikke fungerer"),
(4, "Oppgradering", "2022-04-02", "Forbedre systemytelsen"),
(5, "Vedlikehold", "2022-04-20", "Rutinesjekk og service"),
(6, "Reparere", "2021-06-05", "Løs tilkoblingsproblemer"),
(7, "Oppgradering", "2023-07-06", "Forbedre systemytelsen"),
(8, "Installasjon", "2023-08-07", "Legg til nye deler"),
(9, "Vedlikehold", "2023-09-09", "Inspiser og rengjør"),
(10, "Vedlikehold", "2023-10-17", "Rutinesjekk og service");

-- Service_form - kjører ikke
INSERT INTO  Service_Form (CustomerID_int, Repairdescription_str, ServiceCompleted_date, AgreedDelivery_date, ProductRecived_date,  BookedServiceWeek_int, ShippingMethod_str)
VALUES 
(1, "oodelagt", "2023-01-10", "2023-01-01", "2023-01-02", 1, "med bil"),
(2, "justering", "2023-02-11", "2023-02-02", "2023-02-03", 1, "med posten"),
(3, "oodelagt", "2022-03-12", "2022-03-03", "2022-03-04", 2, "med bil"),
(4, "kontroll", "2022-04-13", "2022-04-04", "2022-04-05", 2, "med bil"),
(5, "oodelagt", "2023-05-14", "2023-05-05", "2023-05-06", 2, "med posten"),
(6, "kontroll", "2023-06-15", "2023-06-06", "2023-06-07", 4, "med bil"),
(7, "justering", "2023-07-16", "2023-07-07", "2023-07-08", 5, "med henting"),
(8, "oodelagt", "2022-08-17", "2022-08-08", "2022-08-09", 5, "med henting"),
(9, "justering", "2023-09-18", "2023-09-09", "2023-09-10", 6, "med bil"),
(10, "kontroll", "2023-10-19", "2023-10-10", "2023-10-11", 7, "med posten");

-- Service_Order_Service_form - kjører ikke
INSERT INTO Service_Order_Service_form (OrderID_int, FormID_int)
VALUES 
(100, 200),
(101, 201),
(102, 202),
(103, 203),
(104, 204),
(105, 205),
(106, 206),
(107, 207),
(108, 208),
(109, 209);

-- Service_Form_Employee kjører ikke
INSERT INTO Service_Form_Employee (FormID_int, EmployeeID_int, Working_Hours_int, Repair_Description_str)
VALUES
    (200, 1, 67, "Byttet metallbit som holder fast en annen metallbit"),
    (201, 2, 42,  "rotor fast, byttet til ny rotor"),
    (202, 3, 10, "oljet vinsj, fungerer bra nå"),
    (203, 4, 14, "vinsj jobber bra nå"),
    (204, 5, 99, "wire løsner ikke lenger konstand"),
    (205, 6, 666, "skiftet skrue"),
    (206, 7, 64, "skiftet metallbit som holder en annen metallbit"),
    (207, 8, 26, "skiftet del, og lakkert til bedrift farge"),
    (208, 9, 73, "gjort ferdig arbeid slik kunden ønsket"),
    (209, 10, 20, "skiftet ny krok");

INSERT INTO Equipment (Name_str, Availability)
VALUES
("Tommersaks", True),
("vinsjhaandtak", False),
("Hammer", False),
("Skrujern", True),
("Drill", True),
("Skrutrekker", False),
("Stikksag", False),
("Slagskrutrekker", True),
("Vinkelskrutrekker", False),
("Multiverktoy", False);
-- Parts
INSERT INTO Parts (PartName_str, Quantity_available_int, EquipmentID_int)
VALUES 
("Staaltau - 8 mm Metervare", 8, 300),
("Gullkjetting m/ krok og tverrpinne", 4, 301),
("Spesialformet m/ stoppeknaster. 160 mm", 8, 302),
("Snarekrok m/ splint", 20, 303),
("Spesialtilpassethurtigkobling", 50, 304),
("Motorsagholder", 13, 305),
("Kasteblokk 2 t", 100, 306),
("Loopekatt", 45, 307),
("Toommersaks", 12, 308),
("Kraftoverføringsakselspesialutfoorelse for vinsj", 22, 309);

-- Service_Form_Sign
INSERT INTO Service_Form_Sign (CustomerID_int, EmployeeID_int, FormID_int, Sign_Date)
VALUES
(1, 10, 200, "2019-12-01"),
(2, 9, 201, "2020-07-21"),
(3, 8, 202, "2021-01-26"),
(4, 7, 203, "1998-01-27"),
(5, 6, 204, "2023-02-02"),
(6, 5, 205, "2023-02-10"),
(7, 4, 206, "2020-05-10"),
(8, 3, 207, "2021-04-30"),
(9, 2, 208, "2022-11-01"),
(10, 1, 209, "2018-06-25");


-- Checklist , kjører ikke
INSERT INTO Checklist (DocID_str, SerialNr_str, Type_str, Procedure_str, Starting_Date, Prepared_by_str, 
xx_Bar_str, Traction_force_Kn, Brake_force, Test_winch, comment_str, Hydraulic_cylinder, Hydraulic_block, Hoses, HOil_gearbox, Ringe_cylinder_and_replace_seals,
Brake_cylinder_and_replace_seals, Clutch_Plate, Check_Brakes, Bearing_drum, PTO_and_storage, Chain_tensioners, Wire, Pinion_bearing, Wedge_on_sprocket, Wiring_on_winch, Test_radio, EOil_gearbox, Button_box)
VALUES
("DOC001", "IG308011", "Type_A", "Procedure_1", "2023-01-01", "Taylor Swift", "Bar_1", "100", "Noen kommentarer","Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok","Ok", "Ok", "Ok", "Ok", "Ok"),
("DOC002", "IG308231", "Type_B", "Procedure_2", "2023-02-01", "Justin Bieber", "Bar_2", "150", "Få kommentarer", "Skiftes", "Defekt", "Ok", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Defekt", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Defekt"),
("DOC003", "IG300622", "Type_C", "Procedure_3", "2023-03-01", "Ed Sheeran", "Bar_3", "200", "Ingen kommentar", "Defekt", "Ok", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Ok", "Ok", "Ok", "Defekt"),
("DOC004", "IG300903", "Type_D", "Procedure_2", "2023-04-01", "Julie Robins", "Bar_3", "120", "Mange kommentarer", "Ok", "Defekt", "Ok", "Defekt", "Ok", "Ok", "Defekt", "Skiftes", "Ok", "Skiftes", "Skiftes", "Ok", "Defekt", "Ok", "Ok", "Ok", "Skiftes", "Ok", "Skiftes", "Ok"),
("DOC005", "IG300990", "Type_E", "Procedure_2", "2022-05-01", "Terje Gjøsæter", "Bar_2", "300", "No comments", "Skiftes", "Defekt", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Ok"),
("DOC006", "IG300052", "Type_F", "Procedure_3", "2022-06-01", "Espen Limi", "Bar_1", "120", "Ingen kommentar", "Ok", "Ok", "Ok", "Defekt", "Skiftes", "Ok", "Skiftes", "Ok", "Ok", "Ok", "Ok", "Ok", "Ok", "Skiftes", "Ok", "Defekt", "Defekt", "Skiftes", "Ok", "Defekt"),
("DOC007", "IG300630", "Type_G", "Procedure_3", "2022-07-01", "Taylor Swift", "Bar_1", "100", "More comments", "Defekt", "Defekt", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Skiftes", "Skiftes", "Ok", "Defekt", "Ok", "Ok", "Defekt",  "Skiftes", "Skiftes", "Ok", "Ok"),
("DOC008", "IG300612", "Type_H", "Procedure_1", "2022-08-01", "Justin Bieber", "Bar_3", "50", "Noen kommentarer", "Ok", "Defekt", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Ok", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes"),
("DOC009", "IG300491", "Type_I", "Procedure_3", "2022-09-01", "Sofie Wass", "Bar_2", "20", "Noen kommentarer", "Skiftes", "Skiftes", "Ok", "Skiftes", "Skiftes", "Ok", "Skiftes", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Ok", "Ok", "Ok", "Skiftes"),
("DOC0010", "IG300191", "Type_J", "Procedure_2", "2022-10-01", "Espen Limi", "Bar_1", "90", "Ingen kommentar", "Defekt", "Defekt", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Skiftes", "Ok", "Defekt", "Defekt", "Defekt", "Defekt", "Ok");

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
(400, 209, 4),
(401, 207, 0),
(402, 208, 16),
(403, 206, 2),
(404, 205, 1),
(405, 200, 4),
(406, 204, 0),
(407, 201, 16),
(408, 202, 2),
(409, 203, 1);

-- Used_Part

INSERT INTO Used_Part (PartID_int, FormID_int, Quantity_used_int)
VALUES
(400, 200, 4),
(401, 201, 0),
(402, 202, 16),
(403, 203, 2),
(404, 204, 1),
(405, 205, 4),
(406, 206, 0),
(407, 207, 16),
(408, 208, 2),
(409, 209, 1);
