using EduHubAPI.CA.Application.Interfaces;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Domain.Products.Entities;
using EduHubAPI.CA.Domain.Sections.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Features.Sections.Commands.CreateSection
{
    public class CreateSectionCommandHandler(ISectionRepository sectionRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateSectionCommand, BaseResult<long>>
    {
        public async Task<BaseResult<long>> Handle(CreateSectionCommand request, CancellationToken cancellationToken)
        {
            var section = new Section() { Title = request.Title };

            await sectionRepository.AddAsync(section);
            await unitOfWork.SaveChangesAsync();


            return section.Id;
        }
    }
}