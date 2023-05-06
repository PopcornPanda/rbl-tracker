using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using rbl_tracker.Services.CheckRblServices;
using rbl_tracker.Dtos.Check;
using System.Security.Claims;

namespace rbl_tracker.Controllers

{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CheckRblController : ControllerBase
    {
        private readonly ICheckRblService _checkRblService;
        public CheckRblController(ICheckRblService checkRblService)
        {
            _checkRblService = checkRblService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetRblCheckHistoryDto>>>> GetAllHistory()
        {
            return Ok(await _checkRblService.RblCheckHistory());
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetRblCheckHistoryDto>>> CheckRbl()
        {
            return Ok(await _checkRblService.RblCheck());
        }
    
    }
}