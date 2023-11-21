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
            
         

            var product = _context.Product.SingleAsync(p => p.SerialNr_str == ServiceOrder.SerialNr);
           
            if (product == null)
            {
                var productDB = new ProductModel { 
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

                _context.SaveChangesAsync();

            }

            var postalCode = _context.Postal_Code.SingleAsync(p => p.Postal_Code_str == ServiceOrder.PostalCode);

            if (postalCode == null)
            {
                var postalCodeDB = new PostalCode { 
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

                _context.SaveChangesAsync();
            }

            var customer = _context.Customer.SingleAsync(c => c.Email_str == ServiceOrder.Email);

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
                var resultCustomer = _context.Customer.Add(customerDB);

                if (resultCustomer == null)
                {
                    ModelState.AddModelError(string.Empty, "Kunde ble ikke lagt til");
                    return View("Serviceordre");
                }
                _context.SaveChangesAsync();
            }

            //CustomerProduct

            //Serviceorder


            //var temp = new ServiceOrderModel{};
            //temp.CustomerID_int = 1;
            //temp.Order_type_str = "vinsj";
            //temp.Received_Date = new DateOnly(2023,11,20);
            //temp.Description_From_Customer_str = "funker ikke";
            //temp.OrderID_int = 11;
            //var result = _context.Service_ordre.Add(temp);
            //if (result != null)
            //{
            //    Console.WriteLine("YAYA");
            //} else
            //{
            //   Console.WriteLine("NANA");  
            //}

            //_context.SaveChanges();





            return View("Serviceordre");
        }
    }
}