using EduHubAPI.CA.Application.Wrappers;
using MediatR;

namespace EduHubAPI.CA.Application.Features.Lessons.Commands.UpdateLesson
{
    public class UpdateLessonCommand : IRequest<BaseResult>
    {
        public long Id { get; set; }
        public string Title { get; set; }
    }
}