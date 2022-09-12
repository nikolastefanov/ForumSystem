

namespace ForumSystem.Models.Home
{
    using ForumSystem.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CategoryViewModel
    {
        public int Id { get; init; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public IEnumerable<Post> Posts { get; init; }
    }
}
