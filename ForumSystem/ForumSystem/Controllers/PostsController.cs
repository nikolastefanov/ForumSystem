

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
                Title = post.Title,
                Content = post.Content,
                CategoryId = post.CategoryId

            };

            this.data.Posts.Add(postData);
            this.data.SaveChanges();

            return RedirectToAction("Index", "Home");


        }

        public IActionResult AllPosts(int categoryId,int currentPage)
        {

            
        

            var postsLists = this.data
                .Posts
                .Where(p => p.CategoryId == categoryId)
                .ToList();


            var lists=postsLists
                .Skip((currentPage - 1) * AllPostsViewModel.PostsPerPage)
                .Take(AllPostsViewModel.PostsPerPage)
                .Select(p => new PostViewModel
                 {
                     Id=p.Id,
                     Title = p.Title,
                     Content = p.Content,
                     CategoryId = p.CategoryId
                 })              
                 .ToList();



            // List<PostViewModel> allPosts  = this.data
            //      .Posts
            //      /*.Skip((query.CurrentPage - 1) * AllPostsViewModel.PostsPerPage)
            //      .Take(AllPostsViewModel.PostsPerPage)*/
            //      .Where(p=>p.CategoryId==categoryId)
            //     .Select(p => new PostViewModel
            //     {
            //         Id=p.Id,
            //         Title = p.Title,
            //         Content = p.Content,
            //         CategoryId = p.CategoryId
            //     })              
            //     .ToList();




            // AllPostsViewModel.CategoryId = categoryId;

        
            ;

            return View(new AllPostsViewModel
            {
                PostsCategory = lists
            }) ;
        }

        [HttpGet]
        public IActionResult PostUpdate(int postId)
        {
            var postUp = this.data
                .Posts
                .Where(p => p.Id == postId)
                .FirstOrDefault();

            var postDetails = new EditPostFormModel
            {

                Id = postUp.Id,
                Title = postUp.Title,
                Content = postUp.Content,
                CategoryId = postUp.CategoryId,
                Categories = this.GetPostCategories()
            };

            return View(postDetails);
        }


        [HttpPost]
        public IActionResult PostUpdate(int postId,EditPostFormModel post)
        {
            var postData = this.data
               .Posts
               .Where(p => p.Id == postId)
               .FirstOrDefault();

            postData.Title = post.Title;
            postData.Content = post.Content;
            postData.CategoryId = post.CategoryId;

            this.data.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult PostDelete(int postId)
        {
            var post = this.data
                .Posts
                .Where(p => p.Id == postId)
                .FirstOrDefault();

            

            this.data.Posts.Remove(post);

            this.data.SaveChanges();

            return Redirect("/Home/Index");
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
