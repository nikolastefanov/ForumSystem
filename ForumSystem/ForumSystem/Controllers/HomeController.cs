using ForumSystem.Data;
using ForumSystem.Models;
using ForumSystem.Models.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ForumSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext data;

        public HomeController(ApplicationDbContext data)
        {
            this.data = data;
        }

        public IActionResult Index()
        {
            return View(new ListCategoryViewModel
            {
                Categories = this.GetCategories()
            });

        }

     
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        private IEnumerable<CategoryViewModel> GetCategories()
        {
            var listCategories = this.data
               .Categories
               .Select(c => new CategoryViewModel
               {
                   Id = c.Id,
                   Name = c.Name,
                   ImageUrl=c.ImageUrl,
                   PostsCount = c.Posts.Count()
               })
               .ToList();


            return listCategories;
        }

    }
}
