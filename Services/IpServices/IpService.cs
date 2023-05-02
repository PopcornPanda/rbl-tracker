using System.Security.Claims;
using AutoMapper;
using rbl_tracker.Dtos.Ip;

namespace rbl_tracker.Services.IpServices
{
    public class IpService : IIpService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IpService(IMapper mapper, DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _mapper = mapper;
        }

        private Guid GetUserId() => Guid.Parse(_httpContextAccessor.HttpContext!.User
            .FindFirstValue(ClaimTypes.NameIdentifier)!);
        public async Task<ServiceResponse<List<GetIpDto>>> AddIp(NewIpDto newIp)
        {
            var serviceResponse = new ServiceResponse<List<GetIpDto>>();
            var ip = _mapper.Map<Ip>(newIp);
            ip.Owner = await _context.Users.FirstOrDefaultAsync(u => u.Id == GetUserId());

            _context.Ips.Add(_mapper.Map<Ip>(ip));
            await _context.SaveChangesAsync();

            serviceResponse.Data =
                await _context.Ips
                .Where(d => d.Owner!.Id == GetUserId())
                .Select(i => _mapper.Map<GetIpDto>(i))
                .ToListAsync();

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetIpDto>>> DeleteIp(Guid id)
        {
            var serviceResponse = new ServiceResponse<List<GetIpDto>>();

            try
            {
                var ip = await _context.Ips.FirstOrDefaultAsync(i => i.Id == id && i.Owner!.Id == GetUserId());
                if (ip is null)
                    throw new Exception($"Ip with Id '{id}' not found");

                _context.Ips.Remove(ip);
                await _context.SaveChangesAsync();

                serviceResponse.Data = await
                    _context.Ips
                    .Where(d => d.Owner!.Id == GetUserId())
                    .Select(i => _mapper.Map<GetIpDto>(i))
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetIpDto>>> GetAllIps(Guid ownerId)
        {
            var serviceResponse = new ServiceResponse<List<GetIpDto>>();
            var ips = await _context.Ips.Include(i => i.Owner)
                .Where(i => i.Owner!.Id == GetUserId()).ToListAsync();
            serviceResponse.Data =
                ips.Select(i => _mapper.Map<GetIpDto>(i)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetIpDto>> GetIpById(Guid id)
        {
            var serviceResponse = new ServiceResponse<GetIpDto>();
            var ips = await _context.Ips.Include(i => i.Owner)
                .Where(i => i.Owner!.Id == GetUserId()).ToListAsync();
            serviceResponse.Data = _mapper.Map<GetIpDto>(ips.FirstOrDefault(i => i.Id == id));
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetIpDto>> GetIpByName(string name)
        {
            var serviceResponse = new ServiceResponse<GetIpDto>();
            var ips = await _context.Ips.Include(i => i.Owner)
                .Where(i => i.Owner!.Id == GetUserId()).ToListAsync();
            serviceResponse.Data = _mapper.Map<GetIpDto>(ips.FirstOrDefault(i => i.Name == name));
            return serviceResponse;
        }


        public async Task<ServiceResponse<GetIpDto>> UpdateIp(UpdateIpDto updatedIp)
        {
            var serviceResponse = new ServiceResponse<GetIpDto>();

            try
            {
                var ip = await _context.Ips.Include(i => i.Owner)
                    .FirstOrDefaultAsync(i => i.Id == updatedIp.Id && i.Owner!.Id == GetUserId());
                if (ip is null || ip.Owner!.Id != GetUserId())
                    throw new Exception($"Ip with Id '{updatedIp.Id}' not found");

                ip.Name = updatedIp.Name;
                ip.Address = updatedIp.Address;
                ip.UpdateTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();

                await _context.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<GetIpDto>(ip);

            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;

        }

    }
}