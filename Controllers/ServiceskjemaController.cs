using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prosjekt.Entities;
using Prosjekt.Models.Services;

namespace Prosjekt.Controllers
{
    public class ServiceSkjemaController : Controller
    {
        private readonly ProsjektContext _context;
    
        // Constructor for ServiceSkjemaController
        public ServiceSkjemaController(ProsjektContext context) {
            _context = context;

        }
        public IActionResult ServiceSkjema()
        {
            return View();
        }

        // Action metode for haandtering av form-innsendelse og lagring av data
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveForm(FormViewModel model)
        {
            try
            {
                // Henter tilsvarende serviceorder basert på det gitte ordernummer
                var serviceOrder = _context.Service_ordre.Where(x => x.OrderID_int == model.OrderNr).FirstOrDefault();

                // Hvis serviceorderen ikke eksisterer, returnerer det en feilmelding
                if (serviceOrder == null)
                {
                    ModelState.AddModelError(string.Empty, "Klarte ikke å lage service order");
                    return RedirectToAction("ServiceSkjema");
                }

                // Lager en ny ServiceFormModel instans med det gitte data
                var serviceFormDB = new ServiceFormModel {
                    AgreedDelivery_date = model.AgreedDelivery_date,
                    BookedServiceWeek_int = model.BookedServiceWeek_int,
                    Repairdescription_str = model.Repairdescription_str,
                    ProductRecived_date = model.ProductRecived_date,
                    ServiceCompleted_date = model.ServiceCompleted_date,
                    ShippingMethod_str = model.ShippingMethod_str
                };
                
                // Henter den nyligste IDen (hvis loggene eksisterer) og angir det til ServiceFormModellen
                int latestId = _context.Service_Form.Any() ? _context.Service_Form.Max(e => e.FormID_int) + 1 : 1;
                serviceFormDB.FormID_int = latestId;
                
                // Legger til ServiceFormModel til databasen og lagrer endringene
                _context.Service_Form.Add(serviceFormDB);
                _context.SaveChanges();

                // Lager en ny ServiceOrderServiceformModel instant som asossierer til service formet med serviceordren
                var formOrder = new ServiceOrderServiceformModel
                {
                    OrderID_int = model.OrderNr,
                    FormID_int = latestId,
                    DocID_str = null
                };

                _context.Service_Order_Service_form.Add(formOrder);
                _context.SaveChanges();
                
                // Lagrer den nyeste IDen i TempData for å bli brukt i neste action
                TempData["id"] = latestId;

                return View("SavePart");
               
                

            } catch (Exception ex)
            {
                // Logger eksepsjonen og omdirigerer til ServiceSkjema view
                Console.WriteLine(ex);
                return Redirect("ServiceSkjema");
            }

        }

        // Actioin metode for haandtering av form-innsendelse og lagrer ReplacePartsReturned og UsedPart data
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SavePart(FormViewModel model)
        {
            try
            {
                // Henter IDen lagret i TempData
                int ID = Int32.Parse(TempData["id"].ToString());

                if (model.ReplacePartName_str !=  null)
                {
                    // Henter tilsvarende part basert på det gitte part navnet
                    var parts = _context.Parts.Where(x => x.PartName_str.Equals(model.ReplacePartName_str)).FirstOrDefault();
                    
                    // Hvis parten ikke eksisterer, returnerer en feilmelding
                    if(parts == null) {
                        ModelState.AddModelError(string.Empty, "Klarte ikke å lage service order");
                        return RedirectToAction("Parts");
                    }
    
                    // Lager en ny ReplacedPartsReturnedModel instans med det gitte data
                    var ReplacedPartDB = new ReplacedPartsReturnedModel
                    {
                        PartID_int = parts.PartID_int,
                        FormID_int= ID,
                        Quantity_int = model.UsedQuantity_available_int
                    };

                    // Legger til ReplacedPartsReturnedModel tili databasen og lagrer endringene
                    _context.Replaced_Parts_Returned.Add(ReplacedPartDB);
                    _context.SaveChanges();
                }

                if(model.UsedPartName_str != null)
                {
                    // Henter tilsvarende part basert på det gitte navnet
                    var parts = _context.Parts.Where(x => x.PartName_str.Equals(model.ReplacePartName_str)).FirstOrDefault();
                    
                    // Hvis parten ikke eksisterer, returnerer en feiilmelding
                    if (parts == null)
                    {
                        ModelState.AddModelError(string.Empty, "Klarte ikke å lage service order");
                        return RedirectToAction("Parts");
                    }
    
                    // Lager en ny UsedPartModel instant med det gitte data
                    var UsedPartDB = new UsedPartModel
                    {
                        PartID_int = parts.PartID_int,
                        FormID_int = ID,
                    
                        Quantity_int = model.UsedQuantity_available_int
                    };

                    _context.Used_Parts.Add(UsedPartDB);
                    _context.SaveChanges();
                }

                // Reset model data
                var resetModel = new FormViewModel
                {
                    ReplacePartName_str = null,
                    UsedPartName_str = null,
                    ReplaceQuantity_available_int = 0,
                    UsedQuantity_available_int = 0
                };

                return View("SavePart", resetModel);


            } catch (Exception ex)
            {
                // Logg eksepsjon og omdirigerer til SavePart view
                Console.WriteLine(ex);
                return View("SavePart");
            }
        }

  


    }
}