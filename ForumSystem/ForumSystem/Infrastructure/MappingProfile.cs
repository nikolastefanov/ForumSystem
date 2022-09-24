

namespace ForumSystem.Infrastructure
{
    using System;
    using AutoMapper;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ForumSystem.Data.Models;
    using ForumSystem.Models.Posts;

    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            this.CreateMap<AddPostFormModel,Post>();

            this.CreateMap<EditPostFormModel, Post>();

            this.CreateMap<PostCategoryViewModel, Category>();
        }

    }
}
