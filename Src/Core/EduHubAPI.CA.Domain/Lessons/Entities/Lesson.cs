using EduHubAPI.CA.Domain.Common;
using EduHubAPI.CA.Domain.Sections.Entities;
using System.Collections;
using System.Collections.Generic;

namespace EduHubAPI.CA.Domain.Lessons.Entities
{
    public class Lesson : AuditableBaseEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? VideoUrl { get; set; }
        public int Order {  get; set; }
        public int? Duration { get; set; }
        public string? Note { get; set; }

        public long? SectionId {  get; set; }
        public Section Section {  get; set; }

        public Lesson(string title)
        {
            Title = title;
        }

        public void Update(string title)
        {
            Title = title;
        }
    }
}
