﻿using Microsoft.AspNetCore.Mvc;
using Prosjekt.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using Prosjekt.Models.Equipment;

namespace Prosjekt.Controllers
{
    [Controller]
    public class EquipmentController : Controller
    {
        private readonly ProsjektContext _context;

        public EquipmentController(ProsjektContext context)
        {

            _context = context;
        }
        [HttpGet]
        public IActionResult Equipment( )
        {
            var equipmentList = _context.Equipment.ToList();

            List<EquimentViewModel> list = new List<EquimentViewModel>();

            // Convert the fetched data to the view model type
            foreach (var e in equipmentList)
            {
                var equipmentObj = new EquimentViewModel { Id_int = e.Id_int, Availability = e.Availability, Name_str = e.Name_str };
                list.Add(equipmentObj);
            }

            ViewData["List"] = list;
            return View( );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddEquipment(EquimentViewModel model)
        {
            var EquipmentDB = _context.Equipment.Where(e => e.Name_str.Equals(model.Name_str)).FirstOrDefault();
            if (EquipmentDB == null)
            {
                var EquipmentObj = new EquipmentModel
                {
                    Availability = model.Availability.Equals("true"),
                    Name_str = model.Name_str,
                };

                int latestId = _context.Equipment.Any() ? _context.Equipment.Max(e => e.Id_int) + 1 : 1;
                EquipmentObj.Id_int = latestId;

                var result = _context.Equipment.Add(EquipmentObj);
                if (result == null)
                {
                    ModelState.AddModelError(string.Empty, "Klarte ikke å lage service order");
                    return RedirectToAction("Equipment");
                }
            }

            _context.SaveChanges();
            return RedirectToAction("Equipment");
        }

        public IActionResult DeleteEquipment(EquimentViewModel model)
        {
            var equipmentToDelete = _context.Equipment.Where(x => x.Id_int == model.Id_int).FirstOrDefault();
            if (equipmentToDelete == null)
            {
                return NotFound();
            }


            // Removing the fk key in parts
            var partDB = _context.Parts.Where(x => x.EquipmentID_int == model.Id_int).ToList();

            foreach (var part in partDB)
            {
                part.EquipmentID_int = null;
            }
            _context.Equipment.Remove(equipmentToDelete);
            _context.SaveChanges();

            return RedirectToAction("Equipment");
        }

    }
}
