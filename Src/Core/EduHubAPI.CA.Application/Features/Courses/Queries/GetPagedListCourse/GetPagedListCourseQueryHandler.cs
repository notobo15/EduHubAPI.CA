using EduHubAPI.CA.Application.Features.Products.Queries.GetPagedListProduct;
using EduHubAPI.CA.Application.Interfaces.Repositories;
using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Domain.Courses.DTOs;
using EduHubAPI.CA.Domain.Products.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Features.Courses.Queries.GetPagedListCourse
{
    public class GetPagedListCourseQueryHandler(ICourseRepository courseRepository) : IRequestHandler<GetPagedListCourseQuery, PagedResponse<CourseDto>>
    {
        public async Task<PagedResponse<CourseDto>> Handle(GetPagedListCourseQuery request, CancellationToken cancellationToken)
        {
            return await courseRepository.GetPagedListAsync(request.PageNumber, request.PageSize, request.Name);
        }
    }
}
