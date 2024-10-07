using EduHubAPI.CA.Application.Parameters;

namespace EduHubAPI.CA.Application.DTOs.Account.Requests
{
    public class GetAllUsersRequest : PaginationRequestParameter
    {
        public string Name { get; set; }
    }
}
