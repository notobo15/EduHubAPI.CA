using EduHubAPI.CA.Application.Helpers;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Application.Interfaces;
using EduHubAPI.CA.Application.Wrappers;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Features.Categories.Commands.DeleteCategory
{
    public class DeleteCategoryCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork, ITranslator translator) : IRequestHandler<DeleteCategoryCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var product = await categoryRepository.GetByIdAsync(request.Id);

            if (product is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_NotFound_with_id(request.Id)), nameof(request.Id));
            }

            categoryRepository.Delete(product);
            await unitOfWork.SaveChangesAsync();

            return BaseResult.Ok();
        }
    }
}