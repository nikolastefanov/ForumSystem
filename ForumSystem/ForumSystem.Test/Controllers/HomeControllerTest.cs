

namespace ForumSystem.Test.Controllers
{
    using ForumSystem.Controllers;
    using ForumSystem.Models.Home;
    using ForumSystem.Test.Mocks;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using Xunit;

    public class HomeControllerTest
    {

        [Fact]
        public void ErrorShouldREturnView()
        {
            //Arange

            var homeController = new HomeController(null,null);

            //Act

            var result = homeController.Error();

            //Assert

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void GetCategoryShouldCorectList()
        {
            //Arange
            var homeController = new HomeController(DataBaseMock.Instance,null);


            //Act

            var result = homeController.GetCategories();

            //Assert

            Assert.NotNull(result);
          
        }
    }
}
