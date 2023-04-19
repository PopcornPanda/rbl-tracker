using rbl_tracker.Dtos.Rbl;
using rbl_tracker.Services.RblServices;
using Microsoft.AspNetCore.Mvc;

namespace rbl_tracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AutoValidateAntiforgeryToken]
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

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetRblDto>>>> GetSingle(Guid id)
        {
            return Ok(await _rblService.GetRblById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetRblDto>>>> AddRbl(NewRblDto newRbl)
        {
            return Ok(await _rblService.AddRbl(newRbl));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<GetRblDto>>>> UpdateRbl(UpdateRblDto updatedRbl)
        {
            var response = await _rblService.UpdateRbl(updatedRbl);
            if (response.Success is false) 
                return NotFound(response);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetRblDto>>>> Delete(Guid id)
        {
            var response = await _rblService.DeleteRbl(id);
            if (response.Success is false) 
                return NotFound(response);

            return Ok(response);
        }
    }
}