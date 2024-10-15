using AutoMapper;
using EduHubAPI.CA.Application.DTOs;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Domain.Categories.DTOs;
using EduHubAPI.CA.Domain.Courses.DTOs;
using EduHubAPI.CA.Domain.Courses.Entities;
using EduHubAPI.CA.Domain.Products.DTOs;
using EduHubAPI.CA.Domain.Products.Entities;
using EduHubAPI.CA.Infrastructure.Persistence.Contexts;
using System.Linq;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository(ApplicationDbContext dbContext, IMapper mapper) : GenericRepository<Category>(dbContext), ICategoryRepository
    {
        public async Task<PaginationResponseDto<CategoryDto>> GetPagedListAsync(int pageNumber, int pageSize, string name)
        {
            var query = dbContext.Categories.OrderBy(p => p.Created).AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Name.Contains(name));
            }
            var categoryDtos = query.Select(course => mapper.Map<CategoryDto>(course));

            return await Paged(
                categoryDtos,
                pageNumber,
                pageSize);

        }
    }
}
