using Microsoft.AspNetCore.Mvc;
using Prosjekt.Entities;

namespace Prosjekt.Controllers
{
    public class PartsController : Controller
    {
        private readonly ProsjektContext _context;

        public PartsController(ProsjektContext context)
        {
            _context = context;
        }

        public IActionResult Parts(string searchString)
        {
            var parts = from p in _context.Parts
                select p;

            if (!string.IsNullOrEmpty(searchString))
            {
                parts = parts.Where(p =>
                    p.PartName_str.Contains(searchString) ||
                    p.PartID_int.ToString().Contains(searchString));
            }

            return View(parts.ToList());
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
        public IActionResult AddPart([Bind("PartID_int,PartName_str,Quantity_available_int")] PartsModel part)
        {
            if (true)//Todo.addmodalstate
            {
                _context.Parts.Add(part);
                _context.SaveChanges();
                return RedirectToAction("Parts");
            }
            return View("Parts", _context.Parts.ToList());
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
