using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Application.Parameters;
using MediatR;
using EduHubAPI.CA.Domain.Categories.DTOs;

namespace EduHubAPI.CA.Application.Features.Categories.Queries.GetCategoriesPagedList
{
    public class GetCategoriesPagedListQuery : PaginationRequestParameter, IRequest<PagedResponse<CategoryDto>>
    {
        public string Name { get; set; }
    }
}
