using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prosjekt.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosjekt.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {

        [TestMethod()]
        public void PrivacyTest()
        {
            var controller = new HomeController();
            var result = controller.Privacy() as ViewResult;
            Assert.AreEqual("Personvern", result.ViewData["Title"]);
        }
    }
}