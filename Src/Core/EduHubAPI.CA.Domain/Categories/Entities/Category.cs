using EduHubAPI.CA.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduHubAPI.CA.Domain.Courses.Entities
{
    public class Category : AuditableBaseEntity
    {
        public string Name { get; set; }
        
        public string? Description { get; set; }

        public long? ParentId { get; set; }
        public Category Parent { get; set; }

        public ICollection<Category> Children { get; set; }

        public Category(string name)
        {
            Name = name;
        }
        public void Update(string name)
        {
            Name = name;
        }
    }
}
