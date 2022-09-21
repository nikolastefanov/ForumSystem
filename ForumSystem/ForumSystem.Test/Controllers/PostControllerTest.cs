

namespace ForumSystem.Test.Controllers
{
    using ForumSystem.Controllers;
    using ForumSystem.Models.Posts;
    using ForumSystem.Test.Mocks;
    using Microsoft.AspNetCore.Mvc;
    using Moq;
    using System;
    using Xunit;

    public class PostControllerTest
    {

        [Fact]
        public void PostAddGetCorrect()
        {

            //Arange

            var postController = new PostsController(DataBaseMock.Instance);

            //Act

            var result = postController.Add();
            //Assert

            Assert.NotNull(result);

            Assert.IsType<ViewResult>(result);
        }


        [Fact]
        public void PostAddPostMethothCorrect()
        {

            //Arange

            var postController = new PostsController(DataBaseMock.Instance);

            //Act
            var result = postController.Add(Mock.Of<AddPostFormModel>());

            //Assert

            Assert.NotNull(result);
            Assert.IsType<RedirectToActionResult>(result);
        }
    }
}
