using EduHubAPI.CA.Application.Features.Courses.Commands.CreateCourse;
using EduHubAPI.CA.Application.Features.Courses.Commands.DeleteCourse;
using EduHubAPI.CA.Application.Features.Courses.Commands.UpdateCourse;
using EduHubAPI.CA.Application.Features.Courses.Queries.GetCourseById;
using EduHubAPI.CA.Application.Features.Courses.Queries.GetPagedListCourse;
using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Domain.Courses.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EduHubAPI.CA.WebApi.Controllers.v1
{
    [ApiVersion("1")]
    public class CoursesController : BaseApiController
    {

        [HttpGet]
        public async Task<PagedResponse<CourseDto>> GetPagedListCourse([FromQuery] GetPagedListCourseQuery model)
            => await Mediator.Send(model);
        [HttpGet]
        public async Task<BaseResult<CourseDto>> GetSectionById([FromQuery] GetCourseByIdQuery model)
       => await Mediator.Send(model);


        [HttpPost]
        public async Task<BaseResult<long>> CreateSection(CreateCourseCommand model)
           => await Mediator.Send(model);

        [HttpPut]
        public async Task<BaseResult> UpdateSection(UpdateCourseCommand model)
            => await Mediator.Send(model);

        [HttpDelete]
        public async Task<BaseResult> DeleteSection([FromQuery] DeleteCourseCommand model)
            => await Mediator.Send(model);

    }
}
