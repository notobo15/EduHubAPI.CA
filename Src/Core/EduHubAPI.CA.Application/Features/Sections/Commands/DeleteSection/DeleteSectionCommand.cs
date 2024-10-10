using EduHubAPI.CA.Application.Wrappers;
using MediatR;

namespace EduHubAPI.CA.Application.Features.Sections.Commands.DeleteSection
{
    public class DeleteSectionCommand : IRequest<BaseResult<long>>
    {
        public long Id { get; set; }
    }
}