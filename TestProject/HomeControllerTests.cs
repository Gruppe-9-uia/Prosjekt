using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Prosjekt.Controllers;

namespace Prosjekt.TestProject.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_ReturnsViewResult()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<HomeController>>();
            var controller = new HomeController(loggerMock.Object);

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}