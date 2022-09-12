

namespace ForumSystem.Controllers
{
    using ForumSystem.Data;
    using ForumSystem.Data.Models;
    using ForumSystem.Models.Posts;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PostsController : Controller
    {
        private readonly ApplicationDbContext data;

        public PostsController(ApplicationDbContext data)
        {
            this.data = data;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View(new AddPostFormModel
            {
                Categories = this.GetPostCategories()
            });
        }

        [HttpPost]
        public IActionResult Add(AddPostFormModel post)
        {

            var postData = new Post
            {
                Title=post.Title,
                Content=post.Content,
                CategoryId=post.CategoryId
             
            };

            this.data.Posts.Add(postData);
            this.data.SaveChanges();

            return RedirectToAction("Index", "Home");
            
            
        }


        private IEnumerable<PostCategoryViewModel> GetPostCategories()
        { 
             var listCategories= this.data
                .Categories
                .Select(c => new PostCategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToList();


            return listCategories;
        }


    }
}
