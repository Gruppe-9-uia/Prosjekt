using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models.Services;
using Prosjekt.Entities;

namespace Prosjekt.Controllers
{
    public class ServiceordreController : Controller
    {
        private readonly ProsjektContext _context;
        
        // Constructor for ServiceordreContorller
        public ServiceordreController(ProsjektContext context)
        {
            _context = context;

        }
        public IActionResult Serviceordre()
        {

            return View();
        }
        
        // Action metode for haandtering av form-innsendelse og lagrer ServiceOrder data
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(ServicesOrderViewModel ServiceOrder)
        {
            // Validerer model state før den prosesserer form data
            if (!ModelState.IsValid)
            {
                return View("Serviceordre");
            }

            try
            {
                // Sjekker om produktet allerede finnes
                var product = _context.Product.Where(p => p.SerialNr_str.Equals(ServiceOrder.SerialNr)).FirstOrDefault();
                
                // Hvis produktet ikke finnes, legges det til i databasen
                if (product == null)
                {
                    var productDB = new ProductModel
                    {
                        SerialNr_str = ServiceOrder.SerialNr,
                        ProductName_str = ServiceOrder.ProductName_str,
                        Model_Year = ServiceOrder.Model_Year,
                        Product_Type_str = ServiceOrder.Product_Type_str
                    };
                    var resultProduct = _context.Product.Add(productDB);

                    if (resultProduct == null)
                    {
                        ModelState.AddModelError(string.Empty, "Produkt ble ikke lagt til");
                        return View("Serviceordre");
                    }

                }

                // Sjekker om postkoden allerede eksisterer
                var postalCode = _context.Postal_Code.Where(p => p.Postal_Code_str.Equals(ServiceOrder.PostalCode)).FirstOrDefault();
                
                // Hvis postkoden ikke eksisterer, legges den til i databasen
                if (postalCode == null)
                {
                    var postalCodeDB = new PostalCode
                    {
                        Postal_Code_str = ServiceOrder.PostalCode,
                        City_str = ServiceOrder.City,
                        State_str = ServiceOrder.State,
                        Country_str = ServiceOrder.Country,
                    };

                    var resultpostalCode = _context.Postal_Code.Add(postalCodeDB);

                    if (resultpostalCode == null)
                    {
                        ModelState.AddModelError(string.Empty, "Postnummer ble ikke lagt til");
                        return View("Serviceordre");
                    }
                }

                // Sjekker om kunden eksisterer
                var customer = _context.Customer.Where(c => c.Email_str.Equals(ServiceOrder.Email)).FirstOrDefault();
                
                // Hvis kunden ikke eksisterer, legges dem til i databasen
                if (customer == null)
                {

                    var customerDB = new CustomerModel
                    {
                        FirstName_str = ServiceOrder.FirstName,
                        LastName_str = ServiceOrder.LastName,
                        Phone_str = ServiceOrder.Phone,
                        Email_str = ServiceOrder.Email,
                        Street_Address_str = ServiceOrder.StreetAddress,
                        Postal_Code_str = ServiceOrder.PostalCode
                    };


                    // Get the latest ID (if any records exist)
                    int latestId = _context.Customer.Any() ? _context.Customer.Max(c => c.ID_int) + 1 : 1;
                    customerDB.ID_int = latestId;

                    var resultCustomer = _context.Customer.Add(customerDB);

                    if (resultCustomer == null)
                    {
                        ModelState.AddModelError(string.Empty, "Kunde ble ikke lagt til");
                        return View("Serviceordre");
                    }
                }




                // Sjekker om Warranty allerede eksisterer 
                var warranty = _context.Warranty.Where(w => w.WarrantyName_str == ServiceOrder.WarrantyName).FirstOrDefault();
                
                // Hvis warranty ikke eksisterer, legges det til i databasen
                if (warranty == null)
                {
                    var warrantyDB = new WarrantyModel { WarrantyName_str = ServiceOrder.WarrantyName };
                    var resultWarranty = _context.Warranty.Add(warrantyDB);

                    if (resultWarranty == null)
                    {
                        ModelState.AddModelError(string.Empty, "Kunde ble ikke lagt til");
                        return View("Serviceordre");
                    }
                }
                
                // Lagrer endringene til databasen
                _context.SaveChanges();
                // CustomerProduct - henter de nødvendige IDene for å lage CustomerProduct logg
                var customerID = _context.Customer.Where(c => c.Email_str.Equals(ServiceOrder.Email)).FirstOrDefault();
                var warrantyID = _context.Warranty.Where(w => w.WarrantyName_str == ServiceOrder.WarrantyName).FirstOrDefault();
                var productID = _context.Product.Where(p => p.SerialNr_str.Equals(ServiceOrder.SerialNr)).FirstOrDefault();
                var CustomerProduct = _context.Customer_Product.Where(c => c.CustomerID_int == customerID.ID_int).FirstOrDefault();

                // Hvis CustomerPrroduct loggen ikke eksisterer, legges den til i databasen
                if (CustomerProduct == null)
                {

                    Console.WriteLine("test1");
                    var CustomerProductDB = new CustomerProductModel
                    {
                        CustomerID_int = customerID.ID_int,
                        SerialNr_str = productID.SerialNr_str,
                        WarrantyID_int = warrantyID.ID_int,
                    };

                    var resultCustomerProduct = _context.Customer_Product.Add(CustomerProductDB);
                    if (resultCustomerProduct == null)
                    {
                        Console.WriteLine("test1");
                        ModelState.AddModelError(string.Empty, "Klarte ikke å koble sammen dataen");
                        return View("Serviceordre");
                    }
                }
                
                // Lagrer endringene til databasen
                _context.SaveChanges();

                // Serviceorder - henter de nødvendige IDene fo å lage ServiceOrder logg
                var CustomerProductID = _context.Service_ordre.Where(c => c.CustomerID_int == customerID.ID_int).FirstOrDefault();
                Console.WriteLine(CustomerProductID);
                Console.WriteLine("test");

                // Hvis ServiceOrder loggen ikke eksisterer, legges den til i databasen
                if (CustomerProductID == null)
                {
                    var serviceOrderDB = new ServiceOrderModel
                    {
                        CustomerID_int = customerID.ID_int,
                        CustomerId = customerID.ID_int,
                        Order_type_str = ServiceOrder.Order_type_str,
                        Description_From_Customer_str = ServiceOrder.Description_From_Customer_str,
                        Received_Date = ServiceOrder.Received_Date,
                        SerialNr_str = ServiceOrder.SerialNr
                    };
                    
                    // Henter den latest ID (hvis logger eksisterer)
                    int latestIdSservice = _context.Service_ordre.Any() ? _context.Service_ordre.Max(so => so.OrderID_int) + 1 : 1;
                    serviceOrderDB.OrderID_int = latestIdSservice;

                    Console.WriteLine(serviceOrderDB.OrderID_int);
                    Console.WriteLine(serviceOrderDB.CustomerID_int);
                    Console.WriteLine(serviceOrderDB.Received_Date);
                    Console.WriteLine(serviceOrderDB.Description_From_Customer_str);

                    var result = _context.Service_ordre.Add(serviceOrderDB);
                    if (result == null)
                    {
                        ModelState.AddModelError(string.Empty, "Klarte ikke å lage service order");
                        return View("Serviceordre");
                    }
                }

                // Lagrer endringene tli databasen
                _context.SaveChanges();

                return RedirectToAction("Oversikt", "Oversikt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View("Serviceordre");
            }
        }
    }
 }