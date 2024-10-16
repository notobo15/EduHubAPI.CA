using System;
using System.Collections.Generic;
using System.Text;

namespace EduHubAPI.CA.Domain.Banners.DTOs
{
    public class BannerDto
    {
        public long Id { get; set; }
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
    }
}
