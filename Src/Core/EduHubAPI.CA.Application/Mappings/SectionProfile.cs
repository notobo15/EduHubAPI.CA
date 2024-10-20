using AutoMapper;
using EduHubAPI.CA.Domain.Sections.DTOs;
using EduHubAPI.CA.Domain.Sections.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Mappings
{
    public class SectionProfile : Profile
    {
        public SectionProfile() {
            CreateMap<Section, SectionDto>()
               .ForMember(dest => dest.Lessons, opt => opt.MapFrom(src => src.Lessons));
        }
    }
}
