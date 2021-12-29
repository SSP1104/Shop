using System;
using Xunit;
using Moq;
using shop.Controllers;
using shop.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using shop.Data.Models;
using ShopControllerTests;
namespace ShopControllerTests
{
    public class CartControllerTest
    {

        [Fact]
        public void Return_NotNull()
        {
            var mockRepo1 = new Mock<iAllCars>();
            var mockRepo2 = new Mock<ShopCart>();
            var controller = new ShopCartController(mockRepo1.Object, mockRepo2.Object);
            var result = controller.Index();
            Assert.NotNull(result);
        }
        [Fact]
        public void Return_ViewResultType()
        {
            var mockRepo1 = new Mock<iAllCars>();
            var mockRepo2 = new Mock<ShopCart>();
            var controller = new ShopCartController(mockRepo1.Object, mockRepo2.Object);
            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Return_addToCart()
        {
            int a = 1;
            var mockRepo1 = new Mock<iAllCars>();
            var mockRepo2 = new Mock<ShopCart>();
            var controller = new ShopCartController(mockRepo1.Object, mockRepo2.Object);
            var result = controller.addToCart(a);
            Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal(result.ToString(), "Index");
        }


    }
}
