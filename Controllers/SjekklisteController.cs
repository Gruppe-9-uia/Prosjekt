using Microsoft.AspNetCore.Mvc;

namespace Prosjekt.Controllers
{
    public class SjekklistController : Controller
    {
        public IActionResult Sjekklist() { 
            return View(); 
        }
    }
}
