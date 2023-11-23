using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models.Services;
using Prosjekt.Entities;

namespace Prosjekt.Controllers
{
    public class ServiceordreController : Controller
    {
        private readonly ProsjektContext _context;

        public ServiceordreController(ProsjektContext context)
        {
            _context = context;

        }
        public IActionResult Serviceordre()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(ServicesOrderViewModel ServiceOrder)
        {
            if (!ModelState.IsValid)
            {
                return View("Serviceordre");
            }

            try
            {
                var product = _context.Product.Where(p => p.SerialNr_str.Equals(ServiceOrder.SerialNr)).FirstOrDefault();

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


                var postalCode = _context.Postal_Code.Where(p => p.Postal_Code_str.Equals(ServiceOrder.PostalCode)).FirstOrDefault();

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


                var customer = _context.Customer.Where(c => c.Email_str.Equals(ServiceOrder.Email)).FirstOrDefault();
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




                //Warranty
                var warranty = _context.Warranty.Where(w => w.WarrantyName_str == ServiceOrder.WarrantyName).FirstOrDefault();

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
                _context.SaveChanges();
                //CustomerProduct
                var customerID = _context.Customer.Where(c => c.Email_str.Equals(ServiceOrder.Email)).FirstOrDefault();
                var warrantyID = _context.Warranty.Where(w => w.WarrantyName_str == ServiceOrder.WarrantyName).FirstOrDefault();
                var productID = _context.Product.Where(p => p.SerialNr_str.Equals(ServiceOrder.SerialNr)).FirstOrDefault();
                var CustomerProduct = _context.Customer_Product.Where(c => c.CustomerID_int == customerID.ID_int).FirstOrDefault();

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

                _context.SaveChanges();

                //Serviceorder
                var CustomerProductID = _context.Service_ordre.Where(c => c.CustomerID_int == customerID.ID_int).FirstOrDefault();
                Console.WriteLine(CustomerProductID);
                Console.WriteLine("test");

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