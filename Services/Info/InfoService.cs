using System.Security.Claims;
using rbl_tracker.Dtos.Auth;
using AutoMapper;

namespace rbl_tracker.Services.Info
{
    public class InfoService : IInfoService
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        public InfoService(IMapper mapper, DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _mapper = mapper;

        }


        public async Task<ServiceResponse<GetUserDto>> Me()
        {
            var response = new ServiceResponse<GetUserDto>();


            var user = await _context.Users
                .Where(u => u.Id == GetUserId())
                .Include(u => u.Hosts)
                .FirstOrDefaultAsync();
            response.Data = _mapper.Map<GetUserDto>(user);


            return response;
        }

        private Guid GetUserId() => Guid.Parse(_httpContextAccessor.HttpContext!.User
            .FindFirstValue(ClaimTypes.NameIdentifier)!);

    }

}