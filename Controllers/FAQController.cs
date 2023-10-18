using Microsoft.AspNetCore.Mvc;

namespace Prosjekt.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult FAQ()
        {
            return View();
        }
    }
}
