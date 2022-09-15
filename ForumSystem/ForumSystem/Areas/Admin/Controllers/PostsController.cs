

namespace ForumSystem.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using static AdminConstants;


    public class PostsController : AdminController
    {

        public IActionResult All()
        {
            return View();
        }
    }
}
