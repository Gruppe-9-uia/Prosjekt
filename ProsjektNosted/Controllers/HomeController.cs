using Microsoft.AspNetCore.Mvc;
using Prosjekt.Models;
using System.Diagnostics;

namespace Prosjekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // constructor for HomeController
        public HomeController(ILogger<HomeController> logger)
        {
        }

        // Action metode for å gjengi standard viewet
        public IActionResult Index()
        {
            return View();
        }
        
        // Action metode for å gjengi Privacy viewet
        public IActionResult Privacy()
        {
            return View();
        }

        // Action metode for å gjengi Error view med detaljert informasjon
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // lager en ErrorViewModel med foreslått informasjon
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
