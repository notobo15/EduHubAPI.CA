using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Application.Parameters;
using MediatR;
using EduHubAPI.CA.Domain.Sections.DTOs;

namespace EduHubAPI.CA.Application.Features.Sections.Queries.GetSectionsPagedList
{
    public class GetSectionsPagedListQuery : PaginationRequestParameter, IRequest<PagedResponse<SectionDto>>
    {
        public string Name { get; set; }
    }
}
