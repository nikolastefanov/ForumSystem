

namespace ForumSystem.Areas.Admin.Models
{
    using ForumSystem.Models.Posts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PostsAdminViewModel
    {

        public IEnumerable<PostViewModel> PostsCategory { get; set; }

    }
}
