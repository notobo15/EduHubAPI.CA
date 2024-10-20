using AutoMapper;
using EduHubAPI.CA.Domain.Banners.DTOs;
using EduHubAPI.CA.Domain.Banners.Entities;
using EduHubAPI.CA.Domain.Sections.DTOs;
using EduHubAPI.CA.Domain.Sections.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Mappings
{
    public class BannerProfile : Profile
    {
        public BannerProfile() {
            CreateMap<Banner, BannerDto>()
               .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));
        }
    }
}
