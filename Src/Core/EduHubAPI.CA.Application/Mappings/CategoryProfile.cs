using AutoMapper;
using EduHubAPI.CA.Domain.Categories.DTOs;
using EduHubAPI.CA.Domain.Courses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile() {

            CreateMap<Category, CategoryDto>()
            .ForMember(dest => dest.ParentName, opt => opt.MapFrom(src => src.Parent.Name));
        }
    }
}
