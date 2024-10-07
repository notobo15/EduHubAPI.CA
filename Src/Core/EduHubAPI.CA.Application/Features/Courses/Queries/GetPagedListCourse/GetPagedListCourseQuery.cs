using EduHubAPI.CA.Application.Parameters;
using EduHubAPI.CA.Application.Wrappers;
using EduHubAPI.CA.Domain.Courses.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Features.Courses.Queries.GetPagedListCourse
{
    public class GetPagedListCourseQuery : PaginationRequestParameter, IRequest<PagedResponse<CourseDto>>
    {
        public string Name { get; set; }
    }
}
