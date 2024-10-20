using EduHubAPI.CA.Application.Helpers;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Application.Interfaces;
using EduHubAPI.CA.Application.Wrappers;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Features.Lessons.Commands.DeleteLesson
{
    public class DeleteLessonCommandHandler(ILessonRepository lessonRepository, IUnitOfWork unitOfWork, ITranslator translator) : IRequestHandler<DeleteLessonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteLessonCommand request, CancellationToken cancellationToken)
        {
            var lesson = await lessonRepository.GetByIdAsync(request.Id);

            if (lesson is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_NotFound_with_id(request.Id)), nameof(request.Id));
            }

            lessonRepository.Delete(lesson);
            await unitOfWork.SaveChangesAsync();

            return BaseResult.Ok();
        }
    }
}