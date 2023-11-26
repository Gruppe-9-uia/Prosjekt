using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Prosjekt.Controllers;
using Prosjekt.Repository;
using Prosjekt.Entities;
using Prosjekt.Models.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Moq;

namespace Prosjekt.Controllers.Tests
{
    [TestClass()]
    public class EquipmentControllerTests
    {
        private IEquipmentRepository equipmentRepository;
        private ILogger<EquipmentController> _logger;

        public void InitializeFakes()
        {
            equipmentRepository = Substitute.For<IEquipmentRepository>();
            equipmentRepository.getAllEquipment().Returns(new List<EquipmentModel> {
                new EquipmentModel { Id_int = 1, Availability = true, Name_str = "Hammer" },
                new EquipmentModel { Id_int = 2, Availability = false, Name_str = "Skrujern" }});
        }

        private EquipmentController GetUnitUnderTest()
        {
            InitializeFakes();
            return new EquipmentController(equipmentRepository, _logger);
        }

        [TestMethod]
        public void EquipmentControllerTest()
        {
            var unitUnderTest = GetUnitUnderTest();
            EquipmentController equipmentController = new EquipmentController(equipmentRepository, _logger);

            var result = equipmentController.Equipment() as ViewResult;
            // Add the relevant data to view model
            List<EquimentViewModel> list = new List<EquimentViewModel>();
            list.Add(new EquimentViewModel { Id = 1, Availability = true, Name = "Hammer" });
            list.Add(new EquimentViewModel { Id = 2, Availability = false, Name = "Skrujern" }); ;

            Assert.IsNotNull(result, "Result burde å være ViewRuelst");
            Assert.IsNotNull(result.ViewData["List"], "View data burde ikke være null");

            var actualList = (List<EquimentViewModel>)result.ViewData["List"];
            for (var i = 0; i < actualList.Count; i++)
            {
                Assert.AreEqual(list[i].Id, actualList[i].Id);
                Assert.AreEqual(list[i].Name, actualList[i].Name);
                Assert.AreEqual(list[i].Availability, actualList[i].Availability);

            }
        }

        [TestMethod]
        public void EquipmentTest()
        {
            var unitUnderTest = GetUnitUnderTest();
            EquipmentController equipmentController = new EquipmentController(equipmentRepository, _logger);

            var result = equipmentController.Equipment() as ViewResult;
            // Add the relevant data to view model
            List<EquimentViewModel> list = new List<EquimentViewModel>();
            list.Add(new EquimentViewModel { Id = 1, Availability = true, Name = "Hammer" });
            list.Add(new EquimentViewModel { Id = 2, Availability = false, Name = "Skrujern" }); ;

            Assert.IsNotNull(result, "Result burde å være ViewRuelst");
            Assert.IsNotNull(result.ViewData["List"], "View data burde ikke være null");

            var actualList = (List<EquimentViewModel>)result.ViewData["List"];
            for (var i = 0; i < actualList.Count; i++)
            {
                Assert.AreEqual(list[i].Id, actualList[i].Id);
                Assert.AreEqual(list[i].Name, actualList[i].Name);
                Assert.AreEqual(list[i].Availability, actualList[i].Availability);

            }
        }

        [TestMethod()]
        public void AddEquipmentTest()
        {
            InitializeFakes();
            var mockService = new Mock<IEquipmentRepository>();
            var controller = new EquipmentController(mockService.Object, _logger);

            var equipmentObj = new AddEquimentModel { Availability = true, Name_str = "Motersag" };

            var result = controller.AddEquipment(equipmentObj);
            mockService.Verify(x => x.InsertEquipment(It.IsAny<EquipmentModel>()), Times.Once);
        }

        [TestMethod]
        public void DeleteEquipmentTest()
        {

            AddEquipmentTest();
            var mockService = new Mock<IEquipmentRepository>();
            var controller = new EquipmentController(mockService.Object, _logger);

            var id_int = 1;
            var equipmentObj = new RemoveEquipmentModel { id = id_int };

            var result = controller.DeleteEquipment(equipmentObj);
            mockService.Verify(x => x.DeleteEquipment(It.Is<int>(id => id == 1)), Times.Once);
        }
    }
}