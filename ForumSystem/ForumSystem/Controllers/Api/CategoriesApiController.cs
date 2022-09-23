

namespace ForumSystem.Controllers.Api
{
    using ForumSystem.Data;
    using ForumSystem.Models.Api;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [ApiController]
    [Route("api/categories")]
    public class CategoriesApiController :ControllerBase
    {
        private readonly ApplicationDbContext data;

        public CategoriesApiController(ApplicationDbContext data)
        {
            this.data = data;
        }

        [HttpGet]
        public IEnumerable<CategoriesListModel> AllCategories()
        {
           var list=this.data
                .Categories
                .Select(c =>new CategoriesListModel
                   {
                    Id=c.Id,
                    ImageUrl=c.ImageUrl,
                    Name=c.Name
                   });

            return  list;
        }


    }
}
