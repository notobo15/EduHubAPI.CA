using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EduHubAPI.CA.Application.DTOs;
using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Application.Interfaces;
using EduHubAPI.CA.Domain.Categories.DTOs;

namespace EduHubAPI.CA.Application.Features.Categories.Queries.GetCategoriesPagedList
{
    public class GetCategoriesPagedListQueryHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork) : IRequestHandler<GetCategoriesPagedListQuery, PagedResponse<CategoryDto>>
    {
        public async Task<PagedResponse<CategoryDto>> Handle(GetCategoriesPagedListQuery request, CancellationToken cancellationToken)
        {
            return await categoryRepository.GetPagedListAsync(request.PageNumber, request.PageSize, request.Name);
        }
    }
}