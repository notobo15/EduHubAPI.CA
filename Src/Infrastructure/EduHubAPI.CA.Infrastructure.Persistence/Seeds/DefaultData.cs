using EduHubAPI.CA.Domain.Courses.Entities;
using EduHubAPI.CA.Domain.Products.Entities;
using EduHubAPI.CA.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Infrastructure.Persistence.Seeds
{
    public static class DefaultData
    {
        public static async Task SeedAsync(ApplicationDbContext applicationDbContext)
        {
            if (!await applicationDbContext.Products.AnyAsync())
            {
                List<Product> defaultProducts = [
                    new Product("Product 1",100000,"111111111111"),
                    new Product("Product 2",150000,"222222222222"),
                    new Product("Product 3",200000,"333333333333"),
                    new Product("Product 4",105000,"444444444444"),
                    new Product("Product 5",200000,"555555555555")
                ];

                await applicationDbContext.Products.AddRangeAsync(defaultProducts);

                await applicationDbContext.SaveChangesAsync();
            }

            if (!await applicationDbContext.Courses.AnyAsync())
            {
                List<Course> defaultCourses = [
                    new Course {Title = "Course 1", Duration = 10000, Price = 100000, Slug = "course-1", Description = ""},
                    new Course {Title = "Course 2", Duration = 20000, Price = 200000, Slug = "course-2", Description = ""},
                    new Course {Title = "Course 3", Duration = 15300, Price = 300000, Slug = "course-3", Description = ""},
                    new Course {Title = "Course 4", Duration = 30000, Price = 400000, Slug = "course-4", Description = ""},
                    new Course {Title = "Course 5", Duration = 40000, Price = 500000, Slug = "course-5", Description = ""},
                ];

                await applicationDbContext.Courses.AddRangeAsync(defaultCourses);

                await applicationDbContext.SaveChangesAsync();
            }
        }
    }
}
