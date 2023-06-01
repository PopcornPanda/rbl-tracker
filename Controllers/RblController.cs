using rbl_tracker.Dtos.Rbl;
using rbl_tracker.Services.RblServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace rbl_tracker.Controllers
{
    [ApiController]
    [Route("api/rbl")]
    public class RblController : ControllerBase
    {
        private readonly IRblService _rblService;

        public RblController(IRblService rblService)
        {
            _rblService = rblService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetRblDto>>>> Get()
        {
            return Ok(await _rblService.GetAllRbls());
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ServiceResponse<List<GetRblDto>>>> GetById(Guid id)
        {
            var response = await _rblService.GetRblById(id);
            if (!response.Success)
                return NotFound(response);

            return Ok(response);
        }

        [HttpGet("{name:alpha}")]
        public async Task<ActionResult<ServiceResponse<List<GetRblDto>>>> GetByName(string name)
        {
            var response = await _rblService.GetRblByName(name);
            if (!response.Success)
                return NotFound(response);

            return Ok(response);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetRblDto>>>> AddRbl(NewRblDto newRbl)
        {
            var response = await _rblService.AddRbl(newRbl);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<GetRblDto>>>> UpdateRbl(UpdateRblDto updatedRbl)
        {
            var response = await _rblService.UpdateRbl(updatedRbl);
            if (!response.Success)
                return NotFound(response);

            return Ok(response);
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetRblDto>>>> Delete(Guid id)
        {
            var response = await _rblService.DeleteRbl(id);
            if (!response.Success)
                return NotFound(response);

            return Ok(response);
        }
    }
}