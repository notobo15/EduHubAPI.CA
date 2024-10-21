﻿using EduHubAPI.CA.Application.DTOs;
using EduHubAPI.CA.Domain.Courses.DTOs;
using EduHubAPI.CA.Domain.Courses.Entities;
using EduHubAPI.CA.Domain.Lessons.DTOs;
using EduHubAPI.CA.Domain.Lessons.Entities;
using EduHubAPI.CA.Domain.Products.DTOs;
using EduHubAPI.CA.Domain.Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Interfaces.Repositories
{
    public interface ILessonRepository : IGenericRepository<Lesson>
    {
        Task<PaginationResponseDto<LessonDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
