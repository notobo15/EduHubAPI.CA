using AutoMapper;
using EduHubAPI.CA.Domain.Instructors.DTOs;
using EduHubAPI.CA.Domain.Instructors.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Mappings
{
    internal class InstructorProfile : Profile
    {
       public InstructorProfile() {
            CreateMap<Instructor, InstructorDto>()
               .ForMember(dest => dest.Courses, opt => opt.MapFrom(src => src.CourseInstructors.Select(ci => ci.Course)));
        }
    }
}
