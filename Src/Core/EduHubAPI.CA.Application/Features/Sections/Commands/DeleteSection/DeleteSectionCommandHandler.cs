using EduHubAPI.CA.Application.Helpers;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Application.Interfaces;
using EduHubAPI.CA.Application.Wrappers;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Features.Sections.Commands.DeleteSection
{
    public class DeleteSectionCommandHandler(ISectionRepository sectionRepository, IUnitOfWork unitOfWork, ITranslator translator) : IRequestHandler<DeleteSectionCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteSectionCommand request, CancellationToken cancellationToken)
        {
            var section = await sectionRepository.GetByIdAsync(request.Id);

            if (section is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_NotFound_with_id(request.Id)), nameof(request.Id));
            }

            sectionRepository.Delete(section);
            await unitOfWork.SaveChangesAsync();

            return BaseResult.Ok();
        }
    }
}