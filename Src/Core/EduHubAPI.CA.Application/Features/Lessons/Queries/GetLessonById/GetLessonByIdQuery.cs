using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Domain.Lessons.DTOs;
using MediatR;

namespace EduHubAPI.CA.Application.Features.Lessons.Queries.GetLessonById
{
    public class GetLessonByIdQuery : IRequest<BaseResult<LessonDto>>
    {
        public long Id { get; set; }
    }
}
