using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EduHubAPI.CA.Application.DTOs;
using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Domain.Sections.DTOs;

namespace EduHubAPI.CA.Application.Features.Sections.Queries.GetSectionsPagedList
{
    public class GetSectionsPagedListQueryHandler(ISectionRepository sectionRepository) : IRequestHandler<GetSectionsPagedListQuery, PagedResponse<SectionDto>>
    {
        public async Task<PagedResponse<SectionDto>> Handle(GetSectionsPagedListQuery request, CancellationToken cancellationToken)
        {
            return await sectionRepository.GetPagedListAsync(request.PageNumber, request.PageSize, request.Name);
        }
    }
}