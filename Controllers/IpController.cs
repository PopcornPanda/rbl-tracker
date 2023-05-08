using rbl_tracker.Dtos.Ip;
using rbl_tracker.Services.IpServices;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace rbl_tracker.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/ip")]
    public class IpController : ControllerBase
    {
        private readonly IIpService _ipService;

        public IpController(IIpService rblService)
        {
            _ipService = rblService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetIpDto>>>> Get()
        {
            return Ok(await _ipService.GetAllIps());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetIpDto>>>> GetById(Guid id)
        {
            return Ok(await _ipService.GetIpById(id));
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<ServiceResponse<List<GetIpDto>>>> GetByName(string name)
        {
            return Ok(await _ipService.GetIpByName(name));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetIpDto>>>> AddIp(NewIpDto newIp)
        {
            return Ok(await _ipService.AddIp(newIp));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<GetIpDto>>>> UpdateIp(UpdateIpDto updatedIp)
        {
            var response = await _ipService.UpdateIp(updatedIp);
            if (response.Success is false)
                return NotFound(response);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetIpDto>>>> Delete(Guid id)
        {
            var response = await _ipService.DeleteIp(id);
            if (response.Success is false)
                return NotFound(response);

            return Ok(response);
        }
    }
}