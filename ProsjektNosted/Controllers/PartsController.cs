using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prosjekt.Entities;
using Prosjekt.Models.Equipment;
using Prosjekt.Models.Parts;
using Prosjekt.Repository;

namespace Prosjekt.Controllers
{
    public class PartsController : Controller
    {
        private IPartsRepository _partsRepository;
        private IEquipmentRepository _equipmentRepository;
        private readonly ILogger<EquipmentController> _logger;


        public PartsController(IPartsRepository partsRepository, IEquipmentRepository equipmentRepository, ILogger<EquipmentController> logger)
        {
            _partsRepository = partsRepository;
            _equipmentRepository = equipmentRepository;
            _logger = logger;
        }


        public IActionResult Parts()
        {

            var PartsList = _partsRepository.getAllParts();
            List<PartsViewModel> list = new List<PartsViewModel>();

            // Convert the fetched data to the view model type
            foreach (var e in PartsList)
            {
                var partsObj = new PartsViewModel
                {
                    PartID_int = e.PartID_int,
                    PartName_str = e.PartName_str,
                    Quantity_available_int = e.Quantity_available_int,
                };

                //check if tehere a equiment connect to a part
                var equipment = _partsRepository.findPartsByEquipmentId(e.EquipmentID_int);
                var equipmentName = (equipment == null) ? null : equipment.Name_str;
                partsObj.EquipmentName = equipmentName;

                list.Add(partsObj);
            }

            // create a list of equipments for drop menu
            var EquipmentListDB = _equipmentRepository.getAllEquipment();
            List<EquimentViewModel> EquipmentList = new List<EquimentViewModel>();
            foreach (var e in EquipmentListDB)
            {
                var EqiupmentObj = new EquimentViewModel
                {
                    Id = e.Id_int,
                    Availability = e.Availability,
                    Name = e.Name_str
                };

                EquipmentList.Add(EqiupmentObj);
            }


            ViewData["Equipment"] = EquipmentList;
            ViewData["List"] = list;
            return View();
        }


        [HttpPost]
        public IActionResult UpdateQuantity(int PartID_int, int NewQuantity)
        {
            if (!ModelState.IsValid)
            {
                //_logger.Log("Model state was not true");
                return View();
            }

            //Check if parts exist, if yes, then update
            var partUpdate = _partsRepository.getPartsByID(PartID_int);
            if (partUpdate != null)
            {
                partUpdate.Quantity_available_int = NewQuantity;
                _partsRepository.UpdateParts(partUpdate);
                _partsRepository.Save();
            }

            return RedirectToAction("Parts");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPart(AddPartsModel model)
        {
            if (!ModelState.IsValid)
            {
                //_logger.Log("Model state was not true");
                return View();
            }

            if(_partsRepository.getPartsByName(model.PartName_str) == null)
            {
                var partsObj = new PartsModel();
                partsObj.PartName_str = model.PartName_str;
                partsObj.Quantity_available_int = model.Quantity_available_int;


                // Check if equipments FK should be add to partsObj
                var equipment = _partsRepository.findPartsByEquipmentName(model.EquipmentName);
                if (equipment != null)
                {
                    partsObj.EquipmentID_int = equipment.Id_int;

                } else {
                    partsObj.EquipmentID_int = null;
                }

                _partsRepository.InsertParts(partsObj);
                _partsRepository.Save();
            }

            return RedirectToAction("Parts");
        }
    
        [HttpPost]
        public IActionResult DeletePart(int partId)
        {
            if (!ModelState.IsValid)
            {
                //_logger.Log("Model state was not true");
                return View();
            }

            //Delect parts if id exists
            _partsRepository.DeleteParts(partId);
            _partsRepository.Save();

            return RedirectToAction("Parts");
        }
    }
}
