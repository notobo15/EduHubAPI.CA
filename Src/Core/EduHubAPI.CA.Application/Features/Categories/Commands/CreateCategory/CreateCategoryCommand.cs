using EduHubAPI.CA.Application.Wrappers;
using MediatR;

namespace EduHubAPI.CA.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand : IRequest<BaseResult<long>>
    {
        public string Name { get; set; }
    }
}