

namespace ForumSystem.Test.Controllers
{
    using ForumSystem.Controllers;
    using ForumSystem.Models.Home;
    using ForumSystem.Test.Mocks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Caching.Memory;
    using Moq;
    using System;
    using Xunit;

    public class HomeControllerTest
    {

        [Fact]
        public void IndexShouldCorrect()
        {
            //Arange
            var data = DataBaseMock.Instance;
            var iMemory = MemoryMock.Instance;

       

            HomeController homeController = new HomeController(data, iMemory);

            //Act

            var result = homeController.Index();
            var resultError = homeController.Error();
            var resultCategories = homeController.GetCategories();

            //Assert

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
            Assert.NotNull(resultError);
            Assert.IsType<ViewResult>(resultError);
            Assert.NotNull(resultCategories);

        }



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
