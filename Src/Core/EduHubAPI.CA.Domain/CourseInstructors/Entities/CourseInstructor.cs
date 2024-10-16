using EduHubAPI.CA.Domain.Common;
using EduHubAPI.CA.Domain.Courses.Entities;
using EduHubAPI.CA.Domain.Instructors.Entities;

namespace EduHubAPI.CA.Domain.CourseInstructors.Entities
{
    public class CourseInstructor : AuditableBaseEntity
    {
        public long? CourseId { get; set; }
        public Course Course { get; set; }

        public long? InstructorId { get; set; }
        public Instructor Instructor { get; set; } 
    }
}
