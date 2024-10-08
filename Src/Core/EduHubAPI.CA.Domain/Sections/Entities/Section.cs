using EduHubAPI.CA.Domain.Common;
using EduHubAPI.CA.Domain.Courses.Entities;
using EduHubAPI.CA.Domain.Lessons.Entities;
using System.Collections.Generic;

namespace EduHubAPI.CA.Domain.Sections.Entities
{
    public class Section : AuditableBaseEntity
    {
        public string Title { get; set; }
        public int Order { get; set; }

        public string? Description { get; set; }

        public long? CourseId { get; set; }
        public Course Course { get; set; }

        public ICollection<Lesson> Lessons { get; set; }


        public void Update(string title)
        {
            Title = title;
        }
    }
}
