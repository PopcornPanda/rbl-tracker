using rbl_tracker.Dtos.Domain;
using rbl_tracker.Services.DomainServices;
using Microsoft.AspNetCore.Mvc;

namespace rbl_tracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DomainController : ControllerBase
    {
        private readonly IDomainService _domainService;

        public DomainController(IDomainService rblService)
        {
            _domainService = rblService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetDomainDto>>>> Get()
        {
            return Ok(await _domainService.GetAllDomains());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetDomainDto>>>> GetById(Guid id)
        {
            return Ok(await _domainService.GetDomainById(id));
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<ServiceResponse<List<GetDomainDto>>>> GetByName(string name)
        {
            return Ok(await _domainService.GetDomainByName(name));
        }

        [HttpGet("{owner}")]
        public async Task<ActionResult<ServiceResponse<List<GetDomainDto>>>> GetByOwner(User owner)
        {
            return Ok(await _domainService.GetDomainByOwner(owner));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetDomainDto>>>> AddDomain(NewDomainDto newDomain)
        {
            return Ok(await _domainService.AddDomain(newDomain));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<GetDomainDto>>>> UpdateDomain(UpdateDomainDto updatedDomain)
        {
            var response = await _domainService.UpdateDomain(updatedDomain);
            if (response.Success is false)
                return NotFound(response);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetDomainDto>>>> Delete(Guid id)
        {
            var response = await _domainService.DeleteDomain(id);
            if (response.Success is false)
                return NotFound(response);

            return Ok(response);
        }
    }
}