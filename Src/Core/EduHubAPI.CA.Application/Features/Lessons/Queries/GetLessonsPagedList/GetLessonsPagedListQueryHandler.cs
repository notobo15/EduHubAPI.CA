using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EduHubAPI.CA.Application.DTOs;
using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Domain.Lessons.DTOs;

namespace EduHubAPI.CA.Application.Features.Lessons.Queries.GetLessonsPagedList
{
    public class GetLessonsPagedListQueryHandler(ILessonRepository lessonRepository) : IRequestHandler<GetLessonsPagedListQuery, PagedResponse<LessonDto>>
    {
        public async Task<PagedResponse<LessonDto>> Handle(GetLessonsPagedListQuery request, CancellationToken cancellationToken)
        {
            return await lessonRepository.GetPagedListAsync(request.PageNumber, request.PageSize, request.Name);
        }
    }
}