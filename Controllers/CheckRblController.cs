using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using rbl_tracker.Services.CheckRblServices;
using rbl_tracker.Dtos.Check;
using System.Security.Claims;

namespace rbl_tracker.Controllers

{
    [Authorize]
    [ApiController]
    [Route("api/checkrbl")]
    public class CheckRblController : ControllerBase
    {
        private readonly ICheckRblService _checkRblService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CheckRblController(ICheckRblService checkRblService, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
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
            return Ok(await _checkRblService.RblCheck(Guid.Parse(_httpContextAccessor.HttpContext!.User
            .FindFirstValue(ClaimTypes.NameIdentifier)!)));
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [NonAction]
        public async Task<ActionResult<ServiceResponse<GetRblCheckHistoryDto>>> CheckUserRbl(Guid id)
        {
            return Ok(await _checkRblService.RblCheck(id));
        }


    }
}