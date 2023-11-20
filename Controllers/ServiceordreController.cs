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
            
            if (false) 
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View("Serviceordre");
            }
     
           
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