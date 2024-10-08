using EduHubAPI.CA.Domain.Courses.Entities;
using EduHubAPI.CA.Domain.Instructors.Entities;
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
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
        }

    }
}
