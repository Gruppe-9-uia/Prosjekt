using Microsoft.AspNetCore.Mvc;

namespace Prosjekt.Controllers
{
    public class FAQController : Controller
    {
        // viser FAQ
        public IActionResult FAQ()
        {
            return View();
        }
    }
}
