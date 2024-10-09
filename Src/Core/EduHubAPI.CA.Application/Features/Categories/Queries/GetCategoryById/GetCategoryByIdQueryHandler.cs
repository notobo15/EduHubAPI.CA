using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Application.Interfaces;
using EduHubAPI.CA.Application.Wrappers;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using EduHubAPI.CA.Application.Helpers;
using EduHubAPI.CA.Domain.Products.DTOs;
using EduHubAPI.CA.Domain.Categories.DTOs;
using AutoMapper;

namespace EduHubAPI.CA.Application.Features.Categories.Queries.GetCategoryById
{
    public class GetCategoryByIdQueryHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork, ITranslator translator, IMapper mapper) : IRequestHandler<GetCategoryByIdQuery, BaseResult<CategoryDto>>
    {
        public async Task<BaseResult<CategoryDto>> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await categoryRepository.GetByIdAsync(request.Id);

            if (category is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_NotFound_with_id(request.Id)), nameof(request.Id));
            }

            return mapper.Map<CategoryDto>(category);
        }
    }
}
