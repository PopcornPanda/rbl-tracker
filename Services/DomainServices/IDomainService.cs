using rbl_tracker.Dtos.Domain;
namespace rbl_tracker.Services.DomainServices
{
    public interface IDomainService
    {
        Task<ServiceResponse<List<GetDomainDto>>> GetAllDomains();
        Task<ServiceResponse<GetDomainDto>> GetDomainById(Guid id);
        Task<ServiceResponse<GetDomainDto>> GetDomainByName(string name);
        Task<ServiceResponse<List<GetDomainDto>>> GetDomainByOwner(User user);
        Task<ServiceResponse<List<GetDomainDto>>> AddDomain(NewDomainDto newDomain);
        Task<ServiceResponse<GetDomainDto>> UpdateDomain(UpdateDomainDto updatedDomain);
        Task<ServiceResponse<List<GetDomainDto>>> DeleteDomain(Guid id);

    }
}