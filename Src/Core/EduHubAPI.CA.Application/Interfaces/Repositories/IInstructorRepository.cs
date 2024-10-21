using EduHubAPI.CA.Application.DTOs;
using EduHubAPI.CA.Domain.Courses.DTOs;
using EduHubAPI.CA.Domain.Courses.Entities;
using EduHubAPI.CA.Domain.Instructors.DTOs;
using EduHubAPI.CA.Domain.Instructors.Entities;
using EduHubAPI.CA.Domain.Products.DTOs;
using EduHubAPI.CA.Domain.Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Interfaces.Repositories
{
    public interface IInstructorRepository : IGenericRepository<Instructor>
    {
        Task<PaginationResponseDto<InstructorDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
