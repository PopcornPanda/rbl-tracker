using rbl_tracker.Dtos.Check;

namespace rbl_tracker.Services.CheckRblServices
{
    public interface ICheckRblService
    {
        Task<ServiceResponse<List<GetRblCheckSimpleHistoryDto>>> RblCheckHistory();
        Task<ServiceResponse<List<GetRblCheckHistoryDto>>> RblCheck(Guid userId);

    }
}