using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prosjekt.Entities;
using Prosjekt.Models.Services;

namespace Prosjekt.Controllers
{
    public class ServiceSkjemaController : Controller
    {
        private readonly ProsjektContext _context;

        public ServiceSkjemaController(ProsjektContext context) {
            _context = context;

        }
        public IActionResult ServiceSkjema()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveForm(FormViewModel model)
        {
            try
            {
                var serviceOrder = _context.Service_ordre.Where(x => x.OrderID_int == model.OrderNr).FirstOrDefault();

                if (serviceOrder == null)
                {
                    ModelState.AddModelError(string.Empty, "Klarte ikke å lage service order");
                    return RedirectToAction("ServiceSkjema");
                }


                var serviceFormDB = new ServiceFormModel {
                    AgreedDelivery_date = model.AgreedDelivery_date,
                    BookedServiceWeek_int = model.BookedServiceWeek_int,
                    Repairdescription_str = model.Repairdescription_str,
                    ProductRecived_date = model.ProductRecived_date,
                    ServiceCompleted_date = model.ServiceCompleted_date,
                    ShippingMethod_str = model.ShippingMethod_str
                };
                int latestId = _context.Service_Form.Any() ? _context.Service_Form.Max(e => e.FormID_int) + 1 : 1;
                serviceFormDB.FormID_int = latestId;
                _context.Service_Form.Add(serviceFormDB);
                _context.SaveChanges();

                var formOrder = new ServiceOrderServiceformModel
                {
                    OrderID_int = model.OrderNr,
                    FormID_int = latestId,
                    DocID_str = null
                };

                _context.Service_Order_Service_form.Add(formOrder);
                _context.SaveChanges();

                TempData["id"] = latestId;

                return View("SavePart");
               
                

            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Redirect("ServiceSkjema");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SavePart(FormViewModel model)
        {
            try
            {
                int ID = Int32.Parse(TempData["id"].ToString());

                if (model.ReplacePartName_str !=  null)
                {
                    var parts = _context.Parts.Where(x => x.PartName_str.Equals(model.ReplacePartName_str)).FirstOrDefault();
                    if(parts == null) {
                        ModelState.AddModelError(string.Empty, "Klarte ikke å lage service order");
                        return RedirectToAction("Parts");
                    }

                    var ReplacedPartDB = new ReplacedPartsReturnedModel
                    {
                        PartID_int = parts.PartID_int,
                        FormID_int= ID,
                        Quantity_int = model.UsedQuantity_available_int
                    };

                    _context.Replaced_Parts_Returned.Add(ReplacedPartDB);
                    _context.SaveChanges();
                }

                if(model.UsedPartName_str != null)
                {
                    var parts = _context.Parts.Where(x => x.PartName_str.Equals(model.ReplacePartName_str)).FirstOrDefault();
                    if (parts == null)
                    {
                        ModelState.AddModelError(string.Empty, "Klarte ikke å lage service order");
                        return RedirectToAction("Parts");
                    }

                    var UsedPartDB = new UsedPartModel
                    {
                        PartID_int = parts.PartID_int,
                        FormID_int = ID,
                    
                        Quantity_int = model.UsedQuantity_available_int
                    };

                    _context.Used_Parts.Add(UsedPartDB);
                    _context.SaveChanges();
                }

                //reset model data
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
                Console.WriteLine(ex);
                return View("SavePart");
            }
        }

  


    }
}