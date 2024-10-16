using EduHubAPI.CA.Domain.Common;
using System;

namespace EduHubAPI.CA.Domain.Banners.Entities
{
    public class Banner : AuditableBaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string BannerUrl { get; set; }
        public string? LinkTo { get; set; }
        public string? Placement { get; set; }
        public int Priority { get; set; }
        public bool IsBlank { get; set; }
        public bool IsPro { get; set; }
        public DateTime Expired { get; set; }
        public string? Type { get; set; }


        public Banner(string name)
        {
            BannerUrl = name;
        }
    }
    
}
