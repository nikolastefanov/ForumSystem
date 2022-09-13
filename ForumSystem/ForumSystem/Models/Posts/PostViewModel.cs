

namespace ForumSystem.Models.Posts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }
 
        public int CategoryId { get; init; }

    }
}
