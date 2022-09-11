

namespace ForumSystem.Infrastructure
{
    using ForumSystem.Data;
    using ForumSystem.Data.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(
            this IApplicationBuilder app)
        {
             using var scopedServices = app.ApplicationServices.CreateScope();
             
             var data = scopedServices.ServiceProvider.GetRequiredService<ApplicationDbContext>();
             
             data.Database.EnsureCreated();

          

                SeedCategories(data);
            

            return app;
        }

        private static void SeedCategories(ApplicationDbContext data)
        {
            if (!data.Categories.Any())
            {
                data.Categories.AddRange(new[]
                {
                new Category { Name = "Science" ,ImageUrl="https://img.freepik.com/free-vector/colorful-science-education-background_23-2148490697.jpg?w=2000"},
                new Category { Name = "Economy" ,ImageUrl="https://keydifferences.com/wp-content/uploads/2019/08/economics-vs-economy.jpg" },
                new Category { Name = "Sport" ,ImageUrl="https://www.gettyimages.no/gi-resources/images/HomepageCurationTilesUK/2021_2_FEBRUARY/SPORT_x9.jpg"},
                new Category { Name = "Тechnical" ,ImageUrl="https://www.sme.org/globalassets/sme.org/training/certifications/technical-certification/cmfgt-image.jpg"}
                });

                data.SaveChanges();
            }

           
        }

    }
}
