using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Application.Interfaces;
using EduHubAPI.CA.Application.Wrappers;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using EduHubAPI.CA.Domain.Courses.Entities;

namespace EduHubAPI.CA.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateCategoryCommand, BaseResult<long>>
    {
        public async Task<BaseResult<long>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = new Category(request.Name);

            await categoryRepository.AddAsync(category);
            await unitOfWork.SaveChangesAsync();

            return category.Id;
        }
    }
}