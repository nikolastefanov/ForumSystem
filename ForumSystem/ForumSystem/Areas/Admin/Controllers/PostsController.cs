

namespace ForumSystem.Areas.Admin.Controllers
{
    using ForumSystem.Data;
    using ForumSystem.Models.Posts;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using static AdminConstants;


    public class PostsController : AdminController
    {

        private readonly ApplicationDbContext data;

        public PostsController(ApplicationDbContext data)
        {
            this.data = data;
        }

        public IActionResult All()
        {

            List<PostViewModel> allPosts = this.data
                 .Posts
                .Select(p => new PostViewModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content,
                    CategoryId = p.CategoryId
                })
                .ToList();

            return View(new AllPostsViewModel
            {
                PostsCategory = allPosts
            });
        }
    }
}
