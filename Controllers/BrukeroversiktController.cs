﻿using System;
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
            var employees = _context.Users.ToList();
            
            return View(employees);
        }

        public IActionResult BackBrukeroversikt()
        {
            return RedirectToAction("Brukeroversikt");
        }
        
        
        public IActionResult GetEmployeeDetails(int employeeID)
        {
            // TODO: burde kanskje gjør om user id til int
<<<<<<< HEAD
            var employee = _context.Users.FirstOrDefault(e => e.Id == employeeID.ToString());
            if (employee != null)
            { 
                return Json(new {Email = employee.Email, Phone = employee.PhoneNumber});
            }
=======
            //var employee = _context.Users.FirstOrDefault(e => e.Id == employeeID);
            //if (employee != null)
            //{
             //   return Json(new {Email = employee.Email_str, Phone = employee.Phone_str});
            //}
>>>>>>> 7e4d952814a321a72c011b796780ec6120924f26

            return Json(null);
        }

        
       
    }
}
