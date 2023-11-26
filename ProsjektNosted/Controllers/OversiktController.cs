using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models.Oversikt;

namespace Prosjekt.Controllers
{
    public class OversiktController : Controller
    {
        private readonly ProsjektContext _context;

        // Constructor for OversiktController
        public OversiktController(ProsjektContext context)
        {
            _context = context;
        }

        // Action metode for å gjengi Oversikt view
        public IActionResult Oversikt()
        {
            // Fetch service ordre fra databasen
            var order = _context.Service_ordre.ToList();


            // Lager en liste forr rå lagre OversiktViewModel objekterr
            List<OversiktViewModel> list = new List<OversiktViewModel>();

            // Convert the fetched data to the view model type
            foreach (var e in order)
            {
                var partsObj = new OversiktViewModel();
                // Henter kundeprodukt informasjon
                var customerPordsduct = _context.Customer_Product.Where(x => x.CustomerID_int == e.CustomerID_int).FirstOrDefault();
                if(customerPordsduct == null)
                {
                    partsObj.WarrantyName = "Ingen garanti";
                    partsObj.Email = "Fant ikke email";
                } else
                {
                    // Henter warranty og kundeinformasjon
                    var warranty = _context.Warranty.Where(x => x.ID_int == customerPordsduct.WarrantyID_int).FirstOrDefault();
                    var customer = _context.Customer.Where(x => x.ID_int == customerPordsduct.CustomerID_int).FirstOrDefault();
                    partsObj.WarrantyName = warranty.WarrantyName_str;
                    partsObj.Email = customer.Email_str;
                }

                // Henter service order service form informasjon
                var Orderform = _context.Service_Order_Service_form.Where(x => x.OrderID_int == e.OrderID_int).FirstOrDefault();
                if (Orderform == null)
                {
                    partsObj.FormID_int = 0;
                    partsObj.BookedServiceWeek_int = 0;
                    partsObj.Repairdescription_str = "Ingen beskrivelse";
                } else
                {
                    // Henter service form informasjon
                    var form = _context.Service_Form.Where(x => x.FormID_int == Orderform.FormID_int).FirstOrDefault();
                    partsObj.FormID_int = form.FormID_int;
                    partsObj.Repairdescription_str = form.Repairdescription_str;
                    partsObj.BookedServiceWeek_int = form.BookedServiceWeek_int;

                }
                // Henter sjekkliste informasjon
                var checklist = _context.Checklist.Where(x => x.DocID_str.Equals(e.SerialNr_str)).FirstOrDefault();

                
                partsObj.OrderID_int = e.OrderID_int;
                partsObj.SerialNr_str = e.SerialNr_str;
                partsObj.Description_From_Customer_str = e.Description_From_Customer_str;

                if(checklist == null)
                {
                    partsObj.DocID_str = "Ingen checkliste";
                } else
                {
                    partsObj.DocID_str = checklist.DocID_str;
                }

                // Legger OversiktViewModel objekt til listen
                list.Add(partsObj);
            }
            // Passerer listen til viewet hvis den inneholder ting
            if (list.Count > 0)
            {
                ViewData["List"] = list;

            }

            return View();
        }
    }
}
