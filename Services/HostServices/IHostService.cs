using rbl_tracker.Dtos.Host;
namespace rbl_tracker.Services.HostServices
{
    public interface IHostService
    {
        Task<ServiceResponse<List<GetHostDto>>> GetAllHosts();
        Task<ServiceResponse<GetHostDto>> GetHostById(Guid id);
        Task<ServiceResponse<GetHostDto>> GetHostByName(string name);
        Task<ServiceResponse<List<GetHostDto>>> AddHost(NewHostDto newHost);
        Task<ServiceResponse<GetHostDto>> UpdateHost(UpdateHostDto updatedHost);
        Task<ServiceResponse<List<GetHostDto>>> DeleteHost(Guid id);

    }
}