using System;
using System.Collections.Generic;
using System.Text;

namespace EduHubAPI.CA.Domain.Categories.DTOs
{
    public class CategoryDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public long? ParentId { get; set; }
        public string? ParentName { get; set; }
    }
}
