using EduHubAPI.CA.Application.Parameters;
using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Domain.Products.DTOs;
using MediatR;

namespace EduHubAPI.CA.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQuery : PaginationRequestParameter, IRequest<PagedResponse<ProductDto>>
    {
        public string Name { get; set; }
    }
}
