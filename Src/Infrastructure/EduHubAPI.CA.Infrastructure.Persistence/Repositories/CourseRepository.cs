using AutoMapper;
using EduHubAPI.CA.Application.DTOs;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Domain.Courses.DTOs;
using EduHubAPI.CA.Domain.Courses.Entities;
using EduHubAPI.CA.Domain.Products.DTOs;
using EduHubAPI.CA.Domain.Products.Entities;
using EduHubAPI.CA.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Infrastructure.Persistence.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {


        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CourseRepository(ApplicationDbContext dbContext, IMapper mapper)
      : base(dbContext)
        {

            _dbContext = dbContext; 
            _mapper = mapper;
        }

        public async Task<PaginationResponseDto<CourseDto>> GetPagedListAsync(int pageNumber, int pageSize, string name)
        {
            var query = _dbContext.Courses.OrderBy(p => p.Created).AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Title.Contains(name));
            }

            var courseDtos = query.Select(course => _mapper.Map<CourseDto>(course));

            return await Paged(
                courseDtos,
                pageNumber,
                pageSize);
        }
    }
}
