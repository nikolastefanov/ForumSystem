

namespace ForumSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
  
    public class Category
    {
        public Category()
        {
            this.Posts = new HashSet<Post>();
        }
        public int Id { get; init; }

        public string Name { get; set; }

        public IEnumerable<Post> Posts { get; init; }

    }
}
