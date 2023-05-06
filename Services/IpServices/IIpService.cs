using rbl_tracker.Dtos.Ip;
namespace rbl_tracker.Services.IpServices
{
    public interface IIpService
    {
        Task<ServiceResponse<List<GetIpDto>>> GetAllIps();
        Task<ServiceResponse<GetIpDto>> GetIpById(Guid id);
        Task<ServiceResponse<GetIpDto>> GetIpByName(string name);
        Task<ServiceResponse<List<GetIpDto>>> AddIp(NewIpDto newIp);
        Task<ServiceResponse<GetIpDto>> UpdateIp(UpdateIpDto updatedIp);
        Task<ServiceResponse<List<GetIpDto>>> DeleteIp(Guid id);

    }
}