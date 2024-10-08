using EduHubAPI.CA.Domain.Courses.Entities;
using EduHubAPI.CA.Domain.Products.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Infrastructure.Persistence.Contexts.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(ci => ci.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Title)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(c => c.Description)
                   .HasMaxLength(1000);

            builder.Property(c => c.Duration)
                   .HasColumnType("int")
                   .HasDefaultValue(null);

            builder.Property(c => c.IconUrl)
                   .HasMaxLength(500);

            builder.Property(c => c.ImageUrl)
                   .HasMaxLength(500);

            builder.Property(c => c.LandingPageUrl)
                   .HasMaxLength(500);

            builder.Property(c => c.OldPrice)
                   .HasColumnType("decimal(18,2)");

            builder.Property(c => c.PreOrderPrice)
                   .HasColumnType("decimal(18,2)");

            builder.Property(c => c.Price)
                   .HasColumnType("decimal(18,2)");

            builder.Property(c => c.Slug)
                   .HasMaxLength(100);

            builder.Property(c => c.PublishedAt)
                   .HasColumnType("datetime");

            builder.Property(c => c.StudentsCount)
                   .HasColumnType("int");

            builder.Property(c => c.VideosCount)
                   .HasColumnType("int");
        }

    }
}
