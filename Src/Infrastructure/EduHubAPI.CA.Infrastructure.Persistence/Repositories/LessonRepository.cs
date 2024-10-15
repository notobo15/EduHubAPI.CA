using AutoMapper;
using EduHubAPI.CA.Application.DTOs;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Domain.Lessons.DTOs;
using EduHubAPI.CA.Domain.Lessons.Entities;
using EduHubAPI.CA.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Infrastructure.Persistence.Repositories
{
    public class LessonRepository : GenericRepository<Lesson>, ILessonRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public LessonRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;

        }


        public async Task<PaginationResponseDto<LessonDto>> GetPagedListAsync(int pageNumber, int pageSize, string name)
        {
            var query = _dbContext.Lessons.OrderBy(p => p.Created).AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Title.Contains(name));
            }

            var sectionDtos = query.Select(course => _mapper.Map<LessonDto>(course));

            return await Paged(
                sectionDtos,
                pageNumber,
                pageSize);
        }
        
    }
}
