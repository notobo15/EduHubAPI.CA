using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Domain.Categories.DTOs;
using MediatR;

namespace EduHubAPI.CA.Application.Features.Categories.Queries.GetCategoryById
{
    public class GetCategoryByIdQuery : IRequest<BaseResult<CategoryDto>>
    {
        public long Id { get; set; }
    }
}
