using EduHubAPI.CA.Domain.Courses.Entities;
using EduHubAPI.CA.Domain.Instructors.DTOs;
using EduHubAPI.CA.Domain.Products.Entities;
using EduHubAPI.CA.Domain.Sections.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace EduHubAPI.CA.Domain.Courses.DTOs
{
    public class CourseDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public string IconUrl { get; set; }
        public string ImageUrl { get; set; }
        public bool IsComingSoon { get; set; }
        public bool IsPreOrder { get; set; }
        public bool IsPro { get; set; }
        public bool IsPublished { get; set; }
        public bool IsSelling { get; set; }
        public string LandingPageUrl { get; set; }
        public decimal OldPrice { get; set; }
        public decimal PreOrderPrice { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Slug { get; set; }
        public int StudentsCount { get; set; }
        public int VideosCount { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public SectionDto Sections { get; set; }

        public CourseDto()
        {
        }

        public CourseDto(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
