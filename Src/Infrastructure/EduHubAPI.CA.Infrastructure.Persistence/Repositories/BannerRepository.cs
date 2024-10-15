using AutoMapper;
using EduHubAPI.CA.Application.DTOs;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Domain.Banners.DTOs;
using EduHubAPI.CA.Domain.Banners.Entities;
using EduHubAPI.CA.Domain.Courses.DTOs;
using EduHubAPI.CA.Domain.Sections.DTOs;
using EduHubAPI.CA.Domain.Sections.Entities;
using EduHubAPI.CA.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Infrastructure.Persistence.Repositories
{
    public class BannerRepository : GenericRepository<Banner>, IBannerRepository
    { 

        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public BannerRepository(ApplicationDbContext dbContext, IMapper mapper)
      : base(dbContext)
        {

            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponseDto<BannerDto>> GetPagedListAsync(int pageNumber, int pageSize, string name)
        {
            var query = _dbContext.Banners.OrderBy(p => p.Created).AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Title.Contains(name));
            }

            var sectionDtos = query.Select(course => _mapper.Map<BannerDto>(course));

            return await Paged(
                sectionDtos,
                pageNumber,
                pageSize);
        }
        
    }
}
