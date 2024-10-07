using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Application.Parameters;
using MediatR;

namespace EduHubAPI.CA.Application.Features.Lessons.Queries.GetLessonsPagedList
{
    public class GetLessonsPagedListQuery : PaginationRequestParameter, IRequest<PagedResponse<Lesson>>
    {
        public Lesson MyProperty { get; set; }
    }
}
