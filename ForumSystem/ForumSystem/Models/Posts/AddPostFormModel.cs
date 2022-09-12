

namespace ForumSystem.Models.Posts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;


    public class AddPostFormModel
    {

        public string Title { get; set; }

        public string Content { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; init; }

        public IEnumerable<PostCategoryViewModel> Categories { get; set; }

    }
}
