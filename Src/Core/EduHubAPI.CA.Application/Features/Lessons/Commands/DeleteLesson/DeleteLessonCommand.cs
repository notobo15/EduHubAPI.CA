using EduHubAPI.CA.Application.Wrappers;
using MediatR;

namespace EduHubAPI.CA.Application.Features.Lessons.Commands.DeleteLesson
{
    public class DeleteLessonCommand : IRequest<BaseResult<long>>
    {
        public long Id { get; set; }
    }
}