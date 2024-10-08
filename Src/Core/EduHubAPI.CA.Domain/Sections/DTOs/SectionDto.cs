using EduHubAPI.CA.Domain.Lessons.DTOs;
using EduHubAPI.CA.Domain.Products.Entities;
using EduHubAPI.CA.Domain.Sections.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace EduHubAPI.CA.Domain.Sections.DTOs
{
    public class SectionDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public string? Description { get; set; }

        public long CourseId { get; set; }
        public ICollection<LessonDto> Lessons { get; set; }

        public SectionDto() { }
        public SectionDto(Section section)
        {
            Id = section.Id;
            Title = section.Title;

        }
    }
}
