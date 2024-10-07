using EduHubAPI.CA.Application.Helpers;
using EduHubAPI.CA.Application.Interfaces;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Domain.Products.DTOs;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQueryHandler(IProductRepository productRepository, ITranslator translator) : IRequestHandler<GetProductByIdQuery, BaseResult<ProductDto>>
    {
        public async Task<BaseResult<ProductDto>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetByIdAsync(request.Id);

            if (product is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_NotFound_with_id(request.Id)), nameof(request.Id));
            }

            return new ProductDto(product);
        }
    }
}
