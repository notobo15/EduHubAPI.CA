using EduHubAPI.CA.Application.Interfaces;
using EduHubAPI.CA.Domain.CourseInstructors.Entities;
using EduHubAPI.CA.Domain.Courses.Entities;
using EduHubAPI.CA.Domain.Instructors.Entities;
using EduHubAPI.CA.Domain.Lessons.Entities;
using EduHubAPI.CA.Domain.Products.Entities;
using EduHubAPI.CA.Domain.Sections.Entities;
using EduHubAPI.CA.Infrastructure.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IAuthenticatedUserService authenticatedUser) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Lesson> Lessons { get; set; }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            ChangeTracker.ApplyAuditing(authenticatedUser);

            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            this.ConfigureDecimalProperties(builder);

            base.OnModelCreating(builder);
        }
    }
}