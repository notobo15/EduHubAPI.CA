using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Application.Parameters;
using MediatR;
using EduHubAPI.CA.Domain.Lessons.DTOs;

namespace EduHubAPI.CA.Application.Features.Lessons.Queries.GetLessonsPagedList
{
    public class GetLessonsPagedListQuery : PaginationRequestParameter, IRequest<PagedResponse<LessonDto>>
    {
        public string Name { get; set; }
    }
}
