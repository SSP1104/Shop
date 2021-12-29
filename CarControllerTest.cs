using System;
using Xunit;
using Moq;
using shop.Controllers;
using shop.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace ShopControllerTests
{
    public class CarControllerTest
    {

        [Fact]
        public void Return_NotNull()
        {
            var mockRepo1 = new Mock<iAllCars>();
            var mockRepo2 = new Mock<iCarsCategory>();
            var controller = new CarsController(mockRepo1.Object, mockRepo2.Object);
            var result = controller.List();
            Assert.NotNull(result);
        }
        [Fact]
        public void Return_ViewResultType()
        {
            var mockRepo1 = new Mock<iAllCars>();
            var mockRepo2 = new Mock<iCarsCategory>();
            var controller = new CarsController(mockRepo1.Object, mockRepo2.Object);
            var result = controller.List();
            Assert.IsType<ViewResult>(result);
        }
    }
}
