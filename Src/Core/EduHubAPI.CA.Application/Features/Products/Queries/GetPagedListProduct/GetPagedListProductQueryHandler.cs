using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Domain.Products.DTOs;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQueryHandler(IProductRepository productRepository) : IRequestHandler<GetPagedListProductQuery, PagedResponse<ProductDto>>
    {
        public async Task<PagedResponse<ProductDto>> Handle(GetPagedListProductQuery request, CancellationToken cancellationToken)
        {
            return await productRepository.GetPagedListAsync(request.PageNumber, request.PageSize, request.Name);
        }
    }
}
