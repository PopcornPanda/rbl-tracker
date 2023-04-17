using rbl_tracker.Dtos.Rbl;
namespace rbl_tracker.Services.RblServices
{
    public interface IRblService
    {
        Task<ServiceResponse<List<GetRblDto>>> GetAllRbls();
        Task<ServiceResponse<GetRblDto>> GetRblById(Guid id);
        Task<ServiceResponse<List<GetRblDto>>> AddRbl(NewRblDto newRbl);
        Task<ServiceResponse<GetRblDto>> UpdateRbl(UpdateRblDto updatedRbl);

    }
}