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
        private readonly DataContext _context;
        public CheckRblController(ICheckRblService checkRblService, IHttpContextAccessor httpContextAccessor, DataContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _checkRblService = checkRblService;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetRblCheckHistoryDto>>>> GetAllHistory()
        {
            return Ok(await _checkRblService.RblCheckHistory());
        }

        [HttpGet("{address}")]
        public async Task<ActionResult<ServiceResponse<List<GetRblCheckHistoryDto>>>> GetHostHistory(string address)
        {
            var owner = Guid.Parse(_httpContextAccessor.HttpContext!.User
            .FindFirstValue(ClaimTypes.NameIdentifier)!);
            var host = await _context.Hosts.Include(i => i.Owner)
                .Where(i => i.Owner!.Id == owner && i.Address == address).FirstOrDefaultAsync();
            if (host is not null)
            {
                return Ok(await _checkRblService.RblCheckHistorySingle(host));
            }
            else
            {
                return NotFound($"Host '{address}' not found");
            }

        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetRblCheckHistoryDto>>> CheckRbl()
        {
            return Ok(await _checkRblService.RblCheck(Guid.Parse(_httpContextAccessor.HttpContext!.User
            .FindFirstValue(ClaimTypes.NameIdentifier)!)));
        }

        [HttpPost("{address}")]
        public async Task<ActionResult<ServiceResponse<GetRblCheckHistoryDto>>> CheckSignleHost(string address)
        {
            var owner = Guid.Parse(_httpContextAccessor.HttpContext!.User
            .FindFirstValue(ClaimTypes.NameIdentifier)!);
            var host = await _context.Hosts.Include(i => i.Owner)
                .Where(i => i.Owner!.Id == owner && i.Address == address).FirstOrDefaultAsync();
            if (host is not null)
            {
                return Ok(await _checkRblService.RblCheckSingle(owner, host));
            }
            else
            {
                return NotFound($"Host '{address}' not found");
            }
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [NonAction]
        public async Task<ActionResult<ServiceResponse<GetRblCheckHistoryDto>>> CheckUserRbl(Guid id)
        {
            return Ok(await _checkRblService.RblCheck(id));
        }


    }
}