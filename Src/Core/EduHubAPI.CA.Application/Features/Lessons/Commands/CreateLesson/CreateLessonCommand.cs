using EduHubAPI.CA.Application.Wrappers;
using MediatR;

namespace EduHubAPI.CA.Application.Features.Lessons.Commands.CreateLesson
{
    public class CreateLessonCommand : IRequest<BaseResult<long>>
    {
        public string Title { get; set; }
    }
}