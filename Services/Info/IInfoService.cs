using rbl_tracker.Dtos.Auth;

namespace rbl_tracker.Services.Info
{
    public interface IInfoService
    {
        Task<ServiceResponse<GetUserDto>> Me();
    }
}