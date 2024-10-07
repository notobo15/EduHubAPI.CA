using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Domain.Products.DTOs;
using MediatR;

namespace EduHubAPI.CA.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<BaseResult<ProductDto>>
    {
        public long Id { get; set; }
    }
}
