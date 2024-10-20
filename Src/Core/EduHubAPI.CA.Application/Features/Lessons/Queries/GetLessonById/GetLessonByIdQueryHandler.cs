using EduHubAPI.CA.Application.Helpers;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Application.Interfaces;
using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Domain.Lessons.DTOs;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;

namespace EduHubAPI.CA.Application.Features.Lessons.Queries.GetLessonById
{
    public class GetLessonByIdQueryHandler(ILessonRepository lessonRepository, ITranslator translator, IMapper mapper) : IRequestHandler<GetLessonByIdQuery, BaseResult<LessonDto>>
    {
        public async Task<BaseResult<LessonDto>> Handle(GetLessonByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await lessonRepository.GetByIdAsync(request.Id);

            if (product is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_NotFound_with_id(request.Id)), nameof(request.Id));
            }
            return mapper.Map<LessonDto>(product);
        }
    }
}
