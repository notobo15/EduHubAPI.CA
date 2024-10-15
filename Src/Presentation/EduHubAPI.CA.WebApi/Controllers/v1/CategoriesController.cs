using EduHubAPI.CA.Application.Features.Categories.Commands.CreateCategory;
using EduHubAPI.CA.Application.Features.Categories.Commands.DeleteCategory;
using EduHubAPI.CA.Application.Features.Categories.Commands.UpdateCategory;
using EduHubAPI.CA.Application.Features.Categories.Queries.GetCategoriesPagedList;
using EduHubAPI.CA.Application.Features.Categories.Queries.GetCategoryById;
using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Domain.Categories.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EduHubAPI.CA.WebApi.Controllers.v1
{
    [ApiVersion("1")]
    public class CategoriesController : BaseApiController
    {

        [HttpGet]
        public async Task<PagedResponse<CategoryDto>> GetPagedListCourse([FromQuery] GetCategoriesPagedListQuery model)
            => await Mediator.Send(model);

        [HttpGet]
        public async Task<BaseResult<CategoryDto>> GetSectionById([FromQuery] GetCategoryByIdQuery model)
          => await Mediator.Send(model);


        [HttpPost]
        public async Task<BaseResult<long>> CreateSection(CreateCategoryCommand model)
           => await Mediator.Send(model);

        [HttpPut]
        public async Task<BaseResult> UpdateCategory(UpdateCategoryCommand model)
            => await Mediator.Send(model);

        [HttpDelete]
        public async Task<BaseResult> DeleteCategory([FromQuery] DeleteCategoryCommand model)
            => await Mediator.Send(model);
    }
}
