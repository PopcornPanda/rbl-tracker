using rbl_tracker.Services.Info;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using rbl_tracker.Dtos.Auth;

namespace rbl_tracker.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/info")]
    public class InfoController : ControllerBase
    {
        private readonly IInfoService _infoService;

        public InfoController(IInfoService infoService)
        {
            _infoService = infoService;
        }

        [Route("me")]
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> Me()
        {
            return Ok(await _infoService.Me());
        }
    }
}