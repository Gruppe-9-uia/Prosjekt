using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Prosjekt.Controllers
{
    public class BrukeroversiktController : Controller {
    
    private readonly ProsjektContext _context;
    // GET

    public BrukeroversiktController(ProsjektContext context)
    {
        _context = context;
    }
        // GET: /<controller>/
        public IActionResult Brukeroversikt() 
        {
            
            return View();
        }

        public IActionResult BackBrukeroversikt()
        {
            return RedirectToAction("Brukeroversikt");
        }
        
       
    }
}
