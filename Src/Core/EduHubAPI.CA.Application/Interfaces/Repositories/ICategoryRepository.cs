using EduHubAPI.CA.Application.DTOs;
using EduHubAPI.CA.Domain.Categories.DTOs;
using EduHubAPI.CA.Domain.Courses.DTOs;
using EduHubAPI.CA.Domain.Courses.Entities;
using EduHubAPI.CA.Domain.Products.DTOs;
using EduHubAPI.CA.Domain.Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Interfaces.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<PaginationResponseDto<CategoryDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
