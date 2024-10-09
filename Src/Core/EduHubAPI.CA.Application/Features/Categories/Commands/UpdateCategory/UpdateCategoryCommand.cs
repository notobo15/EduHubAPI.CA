using EduHubAPI.CA.Application.Wrappers;
using MediatR;

namespace EduHubAPI.CA.Application.Features.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryCommand : IRequest<BaseResult>
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
