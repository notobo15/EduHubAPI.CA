using EduHubAPI.CA.Application.DTOs.Account.Requests;
using EduHubAPI.CA.Application.DTOs.Account.Responses;
using EduHubAPI.CA.Application.Wrappers;
using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Interfaces.UserInterfaces
{
    public interface IAccountServices
    {
        Task<BaseResult<string>> RegisterGhostAccount();
        Task<BaseResult> ChangePassword(ChangePasswordRequest model);
        Task<BaseResult> ChangeUserName(ChangeUserNameRequest model);
        Task<BaseResult<AuthenticationResponse>> Authenticate(AuthenticationRequest request);
        Task<BaseResult<AuthenticationResponse>> AuthenticateByUserName(string username);

    }
}
