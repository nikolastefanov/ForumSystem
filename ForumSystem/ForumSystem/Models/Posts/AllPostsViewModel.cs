

namespace ForumSystem.Models.Posts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class AllPostsViewModel
    {
        public const int PostsPerPage = 2;

        public int CurrentPage { get;  set; } = 1;

        public int TotalPosts { get; set; }

        public int CategoryId { get; set; }


        public IEnumerable<PostViewModel> PostsCategory { get; set; }
    }
}
