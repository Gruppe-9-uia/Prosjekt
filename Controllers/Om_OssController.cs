using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Prosjekt.Controllers
{
    public class Om_OssController : Controller
    {
        // GET: /<controller>/
        public IActionResult Om_Oss()
        {
            return View();
        }
    }
}

