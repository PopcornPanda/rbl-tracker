using rbl_tracker.Dtos.Host;
using rbl_tracker.Services.HostServices;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace rbl_tracker.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/host")]
    public class HostController : ControllerBase
    {
        private readonly IHostService _HostService;

        public HostController(IHostService rblService)
        {
            _HostService = rblService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetHostDto>>>> Get()
        {
            return Ok(await _HostService.GetAllHosts());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetHostDto>>>> GetById(Guid id)
        {
            return Ok(await _HostService.GetHostById(id));
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<ServiceResponse<List<GetHostDto>>>> GetByName(string name)
        {
            return Ok(await _HostService.GetHostByName(name));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetHostDto>>>> AddHost(NewHostDto newHost)
        {
            return Ok(await _HostService.AddHost(newHost));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<GetHostDto>>>> UpdateHost(UpdateHostDto updatedHost)
        {
            var response = await _HostService.UpdateHost(updatedHost);
            if (response.Success is false)
                return NotFound(response);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetHostDto>>>> Delete(Guid id)
        {
            var response = await _HostService.DeleteHost(id);
            if (response.Success is false)
                return NotFound(response);

            return Ok(response);
        }
    }
}