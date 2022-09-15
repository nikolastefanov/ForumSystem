
namespace ForumSystem.Models.Posts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;



    public class EditPostFormModel : AddPostFormModel
    {
        public int Id { get; set; }

    }
}
