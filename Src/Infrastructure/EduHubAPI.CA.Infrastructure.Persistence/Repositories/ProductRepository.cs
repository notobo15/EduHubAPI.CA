using EduHubAPI.CA.Application.DTOs;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Domain.Products.DTOs;
using EduHubAPI.CA.Domain.Products.Entities;
using EduHubAPI.CA.Infrastructure.Persistence.Contexts;
using System.Linq;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Infrastructure.Persistence.Repositories
{
    public class ProductRepository(ApplicationDbContext dbContext) : GenericRepository<Product>(dbContext), IProductRepository
    {
        public async Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name)
        {
            var query = dbContext.Products.OrderBy(p => p.Created).AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Name.Contains(name));
            }

            return await Paged(
                query.Select(p => new ProductDto(p)),
                pageNumber,
                pageSize);

        }
    }
}
