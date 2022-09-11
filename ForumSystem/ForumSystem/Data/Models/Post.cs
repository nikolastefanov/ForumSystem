
namespace ForumSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Post
    {
        public int Id { get; init; }

        public string Title { get; set; }

        public string Content { get; set; }

      
        // forign key => User for ApplicationUsers
       

        public int CategoryId { get; set; }

        public  Category Category { get; set; }

    }
}
