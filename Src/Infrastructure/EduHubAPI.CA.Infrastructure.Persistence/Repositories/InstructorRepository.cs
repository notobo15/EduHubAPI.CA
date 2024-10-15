using AutoMapper;
using EduHubAPI.CA.Application.DTOs;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Domain.Courses.DTOs;
using EduHubAPI.CA.Domain.Instructors.DTOs;
using EduHubAPI.CA.Domain.Instructors.Entities;
using EduHubAPI.CA.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Infrastructure.Persistence.Repositories
{
    internal class InstructorRepository : GenericRepository<Instructor>, IInstructorRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public InstructorRepository(ApplicationDbContext dbContext, IMapper mapper)
      : base(dbContext)
        {

            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<PaginationResponseDto<InstructorDto>> GetPagedListAsync(int pageNumber, int pageSize, string name)
        {
            var query = _dbContext.Instructors.OrderBy(p => p.Created).AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Name.Contains(name));
            }

            var instructorDtos = query.Select(course => _mapper.Map<InstructorDto>(course));

            return await Paged(
                instructorDtos,
                pageNumber,
                pageSize);
        }
    }
}
