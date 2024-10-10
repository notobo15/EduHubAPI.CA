using EduHubAPI.CA.Domain.Courses.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduHubAPI.CA.Domain.Instructors.DTOs
{
    public class InstructorDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? JobTitle { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? FacebookUrl { get; set; }

        public ICollection<CourseDto> Courses { get; set; }
    }
}
