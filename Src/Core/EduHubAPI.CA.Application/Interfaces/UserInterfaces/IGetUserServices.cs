using EduHubAPI.CA.Application.DTOs.Account.Requests;
using EduHubAPI.CA.Application.DTOs.Account.Responses;
using EduHubAPI.CA.Application.Wrappers;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Interfaces.UserInterfaces
{
    public interface IGetUserServices
    {
        Task<PagedResponse<UserDto>> GetPagedUsers(GetAllUsersRequest model);
    }
}
