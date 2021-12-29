using System;
using Xunit;
using Moq;
using shop.Controllers;
using shop.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace ShopControllerTests
{
    public class HomeControllerTest
    {

        [Fact]
        public void Return_NotNull()
        {
            var mockRepo = new Mock<iAllCars>();
            var controller = new HomeController(mockRepo.Object);
            var result = controller.Index();
            Assert.NotNull(result);
        }
        [Fact]
        public void Return_ViewResultType()
        {
            var mockRepo = new Mock<iAllCars>();
            var controller = new HomeController(mockRepo.Object);
            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }
    }
}
