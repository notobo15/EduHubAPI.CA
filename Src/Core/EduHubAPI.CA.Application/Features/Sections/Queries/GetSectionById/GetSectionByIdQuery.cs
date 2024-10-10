using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Domain.Sections.DTOs;
using MediatR;

namespace EduHubAPI.CA.Application.Features.Sections.Queries.GetSectionById
{
    public class GetSectionByIdQuery : IRequest<BaseResult<SectionDto>>
    {
        public long Id { get; set; }
    }
}
