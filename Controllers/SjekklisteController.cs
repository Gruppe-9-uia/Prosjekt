using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models;

namespace Prosjekt.Controllers
{
    public class SjekklistController : Controller
    {

        public IActionResult Sjekklist() { 
            return View(); 
        }

        [HttpPost]
        public IActionResult generelForm(SjekklisteModel Sjekkliste)
        {
            if (!ModelState.IsValid) return View();


            return View();
        } 
    }
}
