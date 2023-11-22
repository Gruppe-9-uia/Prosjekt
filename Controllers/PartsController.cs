using Microsoft.AspNetCore.Mvc;
using Prosjekt.Entities;
using Prosjekt.Models.Parts;


namespace Prosjekt.Controllers
{
    public class PartsController : Controller
    {
        private readonly ProsjektContext _context;

        public PartsController(ProsjektContext context)
        {
            _context = context;
        }


        public IActionResult Parts()
        {
            var PartsList = _context.Parts.ToList();
            


            List<PartsViewModel> list = new List<PartsViewModel>();

            // Convert the fetched data to the view model type
            foreach (var e in PartsList)
            {
                var equipment = _context.Equipment.Where(x=> x.Id_int == e.EquipmentID_int).FirstOrDefault();
                var partsObj = new PartsViewModel { 
                    PartID_int = e.PartID_int, 
                    PartName_str = e.PartName_str, 
                    Quantity_available_int = e.Quantity_available_int,
                    EquipmentName = equipment.Name_str
                    };
                list.Add(partsObj);
            }

            if(list.Count > 0)
            {
                ViewData["List"] = list;

            }
            return View();
        }


        [HttpPost]
        public IActionResult UpdateQuantity(int PartID_int, int NewQuantity)
        {
            var part = _context.Parts.FirstOrDefault(p => p.PartID_int == PartID_int);
            if (part != null)
            {
                part.Quantity_available_int = NewQuantity;
                _context.SaveChanges();
            }

            return RedirectToAction("Parts");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPart(PartsViewModel model)
        {
            var PartsDB = _context.Parts.Where(e => e.PartName_str.Equals(model.PartName_str)).FirstOrDefault();

            //TODO: f�r ikke hente equipment
            var equipment = _context.Equipment.Where(e => e.Name_str.Equals(model.EquipmentName)).FirstOrDefault();
            Console.WriteLine(model.EquipmentName);
            if(PartsDB == null &&  equipment != null)
            {
                var partsObj = new PartsModel
                {
                    PartID_int = model.PartID_int,
                    PartName_str = model.PartName_str,
                    Quantity_available_int = model.Quantity_available_int,
                    EquipmentID_int = equipment.Id_int
                };

                int latestId = _context.Parts.Any() ? _context.Parts.Max(e => e.PartID_int) + 1 : 1;
                partsObj.PartID_int = latestId;

                var result = _context.Parts.Add(partsObj);
                if (result == null)
                {
                    ModelState.AddModelError(string.Empty, "Klarte ikke � lage service order");
                    return RedirectToAction("Parts");
                }

            }


            return RedirectToAction("Parts");
        }
    
        [HttpPost]
        public IActionResult DeletePart(int partId)
        {
            var part = _context.Parts.FirstOrDefault(p => p.PartID_int == partId);
            if (part != null)
            {
                _context.Parts.Remove(part);
                _context.SaveChanges();
            }

            return RedirectToAction("Parts");
        }
    }
}
