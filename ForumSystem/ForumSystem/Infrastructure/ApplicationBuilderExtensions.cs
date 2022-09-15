

namespace ForumSystem.Infrastructure
{
    using ForumSystem.Data;
    using ForumSystem.Data.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using static WebConstants;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(
            this IApplicationBuilder app)
        {
             using var serviceScope = app.ApplicationServices.CreateScope();

            // var data = scopedServices.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            var services = serviceScope.ServiceProvider;

            //data.Database.EnsureCreated();

            MigrateDatabase(services);

            SeedCategories(services);
            SeedAdministrator(services);


            return app;
        }
        private static void MigrateDatabase(IServiceProvider services)
        {
            var data = services.GetRequiredService<ApplicationDbContext>();

            //data.Database.Migrate();
            data.Database.EnsureCreated();

        }



        private static void SeedCategories(IServiceProvider services)
        {
            var data = services.GetRequiredService<ApplicationDbContext>();


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


        private static void SeedAdministrator(IServiceProvider services)
        {
            var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task
                .Run(async () =>
                {
                    if (await roleManager.RoleExistsAsync(AdministratorRoleName))
                    {
                        return;
                    }

                    var role = new IdentityRole { Name = AdministratorRoleName };

                    await roleManager.CreateAsync(role);

                    const string adminEmail = "admin@fs.com";
                    const string adminPassword = "admin12";

                    var user = new IdentityUser
                    {
                        Email = adminEmail,
                        UserName = adminEmail,
                        //FullName = "Admin"
                    };

                    await userManager.CreateAsync(user, adminPassword);

                    await userManager.AddToRoleAsync(user, role.Name);
                })
                .GetAwaiter()
                .GetResult();
        }

    }
}
