using EduHubAPI.CA.Application.Features.Sections.Commands.CreateSection;
using EduHubAPI.CA.Application.Features.Sections.Commands.DeleteSection;
using EduHubAPI.CA.Application.Features.Sections.Commands.UpdateSection;
using EduHubAPI.CA.Application.Features.Sections.Queries.GetSectionById;
using EduHubAPI.CA.Application.Features.Sections.Queries.GetSectionsPagedList;
using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Domain.Sections.DTOs;
using EduHubAPI.CA.Domain.Sections.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EduHubAPI.CA.WebApi.Controllers.v1
{
    [ApiVersion("1")]
    public class SectionsController : BaseApiController
    {

        [HttpGet]
        public async Task<PagedResponse<SectionDto>> GetPagedListCourse([FromQuery] GetSectionsPagedListQuery model)
            => await Mediator.Send(model);

        [HttpGet]
        public async Task<BaseResult<SectionDto>> GetSectionById([FromQuery] GetSectionByIdQuery model)
          => await Mediator.Send(model);


        [HttpPost]
        public async Task<BaseResult<long>> CreateSection(CreateSectionCommand model)
           => await Mediator.Send(model);

        [HttpPut]
        public async Task<BaseResult> UpdateSection(UpdateSectionCommand model)
            => await Mediator.Send(model);

        [HttpDelete]
        public async Task<BaseResult> DeleteSection([FromQuery] DeleteSectionCommand model)
            => await Mediator.Send(model);
    }
}
