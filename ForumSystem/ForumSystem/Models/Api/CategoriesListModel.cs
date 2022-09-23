
namespace ForumSystem.Models.Api
{
    using ForumSystem.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class CategoriesListModel
    {
        public int Id { get; init; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public IEnumerable<Post> Posts { get; init; }

        public int PostsCount { get; set; }

    }
}
