using EduHubAPI.CA.Application.DTOs;
using EduHubAPI.CA.Domain.Products.DTOs;
using EduHubAPI.CA.Domain.Products.Entities;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
