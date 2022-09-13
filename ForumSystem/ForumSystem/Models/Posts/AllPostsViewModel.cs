

namespace ForumSystem.Models.Posts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class AllPostsViewModel
    {

        public IEnumerable<PostViewModel> PostsCategory { get; set; }
    }
}
