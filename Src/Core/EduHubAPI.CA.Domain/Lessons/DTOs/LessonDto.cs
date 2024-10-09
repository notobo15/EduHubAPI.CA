using System;
using System.Collections.Generic;
using System.Text;

namespace EduHubAPI.CA.Domain.Lessons.DTOs
{
    public class LessonDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? VideoUrl { get; set; }
        public int Order { get; set; }
        public int? Duration { get; set; }
        public string? Note { get; set; }

        public long SectionId { get; set; }

        public LessonDto() { }
    }
}
