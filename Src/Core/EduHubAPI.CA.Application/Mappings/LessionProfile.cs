using AutoMapper;
using EduHubAPI.CA.Domain.Lessons.DTOs;
using EduHubAPI.CA.Domain.Lessons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Mappings
{
    public class LessionProfile : Profile
    {
        public LessionProfile() {
            CreateMap<Lesson, LessonDto>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));
        }
    }
}
