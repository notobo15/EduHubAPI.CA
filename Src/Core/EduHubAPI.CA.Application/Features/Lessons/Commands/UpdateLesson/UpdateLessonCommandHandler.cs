using EduHubAPI.CA.Application.Helpers;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Application.Interfaces;
using EduHubAPI.CA.Application.Wrappers;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Features.Lessons.Commands.UpdateLesson
{
    public class UpdateLessonCommandHandler(ILessonRepository lessonRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<UpdateLessonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateLessonCommand request, CancellationToken cancellationToken)
        {
            var lesson = await lessonRepository.GetByIdAsync(request.Id);

            if (lesson is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_NotFound_with_id(request.Id)), nameof(request.Id));
            }

            lesson.Update(request.Title);
            await unitOfWork.SaveChangesAsync();

            return BaseResult.Ok();
        }
    }
}