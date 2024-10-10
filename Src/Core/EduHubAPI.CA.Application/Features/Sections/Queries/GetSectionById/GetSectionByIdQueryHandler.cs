using EduHubAPI.CA.Application.Helpers;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Application.Interfaces;
using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Domain.Sections.DTOs;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;

namespace EduHubAPI.CA.Application.Features.Sections.Queries.GetSectionById
{
    public class GetSectionByIdQueryHandler(ISectionRepository sectionRepository, ITranslator translator, IMapper mapper) : IRequestHandler<GetSectionByIdQuery, BaseResult<SectionDto>>
    {
        public async Task<BaseResult<SectionDto>> Handle(GetSectionByIdQuery request, CancellationToken cancellationToken)
        {
            var section = await sectionRepository.GetByIdAsync(request.Id);

            if (section is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_NotFound_with_id(request.Id)), nameof(request.Id));
            }


            return mapper.Map<SectionDto>(section);
        }
    }
}
