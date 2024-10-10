using EduHubAPI.CA.Domain.Common;
using EduHubAPI.CA.Domain.CourseInstructors.Entities;
using EduHubAPI.CA.Domain.Instructors.Entities;
using EduHubAPI.CA.Domain.Sections.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduHubAPI.CA.Domain.Courses.Entities
{
    public class Course :  AuditableBaseEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public int? Duration { get; set; }
        public string? IconUrl { get; set; }
        public string? ImageUrl { get; set; }
        public bool? IsComingSoon { get; set; }
        public bool? IsPreOrder { get; set; }
        public bool? IsPro { get; set; }
        public bool? IsPublished { get; set; }
        public bool? IsSelling { get; set; }
        public string? LandingPageUrl { get; set; }
        public decimal? OldPrice { get; set; }
        public decimal? PreOrderPrice { get; set; }
        public decimal? Price { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string? Slug { get; set; }
        public int? StudentsCount { get; set; }
        public int? VideosCount { get; set; }

        public long? CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Instructor> Instructors { get; set; }
        public ICollection<Section> Sections { get; set; }
        public ICollection<CourseInstructor> CourseInstructors { get; set; }

        public Course(string title)
        {
            Title = title;
        }

        public Course()
        {
        }

        public void Update(string title)
        {
            Title = title;
        }
    }


}
