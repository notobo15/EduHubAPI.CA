using EduHubAPI.CA.Application.Wrappers;
using MediatR;

namespace EduHubAPI.CA.Application.Features.Sections.Commands.CreateSection
{
    public class CreateSectionCommand : IRequest<BaseResult<long>>
    {
        public string Title { get; set; }

        public string Description { get; set; }
    }
}