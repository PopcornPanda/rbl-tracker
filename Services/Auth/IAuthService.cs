using rbl_tracker.Dtos.Auth;

namespace rbl_tracker.Services.Auth
{
    public interface IAuthService
    {
        Task<ServiceResponse<Guid>> Register(User user, string passwowrd);
        Task<ServiceResponse<string>> Login(string username, string passwowrd);
        Task<bool> UserExists(string username);
    }
}