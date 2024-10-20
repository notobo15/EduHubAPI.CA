using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Application.Interfaces;
using EduHubAPI.CA.Application.Wrappers;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using EduHubAPI.CA.Domain.Lessons.Entities;

namespace EduHubAPI.CA.Application.Features.Lessons.Commands.CreateLesson
{
    public class CreateLessonCommandHandler(ILessonRepository lessonRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateLessonCommand, BaseResult<long>>
    {
        public async Task<BaseResult<long>> Handle(CreateLessonCommand request, CancellationToken cancellationToken)
        {
            var lesson = new Lesson(request.Title);

            await lessonRepository.AddAsync(lesson);
            await unitOfWork.SaveChangesAsync();

            return lesson.Id;
        }
    }
}