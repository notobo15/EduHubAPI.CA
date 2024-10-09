using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Application.Interfaces;
using EduHubAPI.CA.Application.Wrappers;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using EduHubAPI.CA.Application.Helpers;

namespace EduHubAPI.CA.Application.Features.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork, ITranslator translator) : IRequestHandler<UpdateCategoryCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await categoryRepository.GetByIdAsync(request.Id);

            if (category is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_NotFound_with_id(request.Id)), nameof(request.Id));
            }

            category.Update(request.Name);
            await unitOfWork.SaveChangesAsync();

            return BaseResult.Ok();
        }
    }
}