using ForumSystem.Data;
using ForumSystem.Models;
using ForumSystem.Models.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
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
        private readonly IMemoryCache cache;
        object CategoryCacheKey = null;

        public HomeController(ApplicationDbContext data, IMemoryCache cache)
        {
            this.data = data;
            this.cache = cache;
        }

        public IActionResult Index()
        {

            var categories = this.GetCategories();

            //  var categories = this.cache.Get<List<CategoryViewModel>>(CategoryCacheKey);
            //
            //  if (categories == null)
            //  {
            //    categories = this.GetCategories();
            //      var cacheOptions = new MemoryCacheEntryOptions()
            //           .SetAbsoluteExpiration(TimeSpan.FromMinutes(1));
            //
            //      this.cache.Set(CategoryCacheKey, categories, cacheOptions);
            //  }


            return View(new ListCategoryViewModel
            {
                Categories = categories
            });

        }

     
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            return View();
        }


        public IEnumerable<CategoryViewModel> GetCategories()
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
