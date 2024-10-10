using EduHubAPI.CA.Application.Wrappers;
using MediatR;

namespace EduHubAPI.CA.Application.Features.Sections.Commands.UpdateSection
{
    public class UpdateSectionCommand : IRequest<BaseResult<long>>
    {
        public long Id { get; set; }
        public string Title { get; set; }
    }
}