using rbl_tracker.Dtos.Check;

namespace rbl_tracker.Services.CheckRblServices
{
    public interface ICheckRblService
    {
        Task<ServiceResponse<List<GetRblCheckSimpleHistoryDto>>> RblCheckHistory();
        Task<ServiceResponse<List<GetRblCheckSimpleHistoryDto>>> RblCheckHistorySingle(Models.Host host);
        Task<ServiceResponse<List<GetRblCheckHistoryDto>>> RblCheck(Guid userId);
        Task<ServiceResponse<List<GetRblCheckHistoryDto>>> RblCheckSingle(Guid userId, Models.Host host);

    }
}