using EduHubAPI.CA.Domain.Common;
using EduHubAPI.CA.Domain.CourseInstructors.Entities;
using System.Collections;
using System.Collections.Generic;

namespace EduHubAPI.CA.Domain.Instructors.Entities
{
    public class Instructor : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? JobTitle { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? FacebookUrl { get; set; }

        public ICollection<CourseInstructor> CourseInstructors { get; set; }

        public Instructor(string name)
        {
            Name = name;
        }

        public void Update(string name)
        {
            Name = name;
        }
    }
}
