using System.Security.Claims;
using AutoMapper;
using rbl_tracker.Dtos.Host;
using System.Net;

namespace rbl_tracker.Services.HostServices
{
    public class HostService : IHostService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HostService(IMapper mapper, DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _mapper = mapper;
        }

        private Guid GetUserId() => Guid.Parse(_httpContextAccessor.HttpContext!.User
            .FindFirstValue(ClaimTypes.NameIdentifier)!);

        public async Task<ServiceResponse<List<GetHostDto>>> AddHost(NewHostDto newHost)
        {
            IPAddress ValidateHost;
            var serviceResponse = new ServiceResponse<List<GetHostDto>>();
            var host = _mapper.Map<Models.Host>(newHost);
            host.Owner = await _context.Users.FirstOrDefaultAsync(u => u.Id == GetUserId());

            if (host.isDomain){
                if (Uri.CheckHostName(host.Address).Equals(UriHostNameType.Dns) is false)
                    throw new Exception($"Provided Domain is not valid");
            } else {
            if (IPAddress.TryParse(host.Address, out ValidateHost!) is false)
                throw new Exception($"Provided Host is not valid IP address");
            }

            _context.Hosts.Add(_mapper.Map<Models.Host>(host));
            await _context.SaveChangesAsync();

            serviceResponse.Data =
                await _context.Hosts
                .Where(d => d.Owner!.Id == GetUserId())
                .Select(i => _mapper.Map<GetHostDto>(i))
                .ToListAsync();

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetHostDto>>> DeleteHost(Guid id)
        {
            var serviceResponse = new ServiceResponse<List<GetHostDto>>();

            try
            {
                var host = await _context.Hosts.FirstOrDefaultAsync(i => i.Id == id && i.Owner!.Id == GetUserId());
                if (host is null)
                    throw new Exception($"Host with Id '{id}' not found");

                _context.Hosts.Remove(host);
                await _context.SaveChangesAsync();

                serviceResponse.Data = await
                    _context.Hosts
                    .Where(d => d.Owner!.Id == GetUserId())
                    .Select(i => _mapper.Map<GetHostDto>(i))
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetHostDto>>> GetAllHosts()
        {
            var serviceResponse = new ServiceResponse<List<GetHostDto>>();
            var hosts = await _context.Hosts.Include(i => i.Owner)
                .Where(i => i.Owner!.Id == GetUserId()).ToListAsync();
            serviceResponse.Data =
                hosts.Select(i => _mapper.Map<GetHostDto>(i)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetHostDto>> GetHostById(Guid id)
        {
            var serviceResponse = new ServiceResponse<GetHostDto>();
            var hosts = await _context.Hosts.Include(i => i.Owner)
                .Where(i => i.Owner!.Id == GetUserId()).ToListAsync();
            serviceResponse.Data = _mapper.Map<GetHostDto>(hosts.FirstOrDefault(i => i.Id == id));
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetHostDto>> GetHostByName(string name)
        {
            var serviceResponse = new ServiceResponse<GetHostDto>();
            var hosts = await _context.Hosts.Include(i => i.Owner)
                .Where(i => i.Owner!.Id == GetUserId()).ToListAsync();
            serviceResponse.Data = _mapper.Map<GetHostDto>(hosts.FirstOrDefault(i => i.Name == name));
            return serviceResponse;
        }


        public async Task<ServiceResponse<GetHostDto>> UpdateHost(UpdateHostDto updatedHost)
        {
            var serviceResponse = new ServiceResponse<GetHostDto>();

            try
            {
                IPAddress ValidateHost;
                var host = await _context.Hosts.Include(i => i.Owner)
                    .FirstOrDefaultAsync(i => i.Id == updatedHost.Id && i.Owner!.Id == GetUserId());
                if (host is null || host.Owner!.Id != GetUserId())
                    throw new Exception($"Host with Id '{updatedHost.Id}' not found");

                if (IPAddress.TryParse(host.Address, out ValidateHost!) is false)
                    throw new Exception($"Provided Host is not valid");

                host.Name = updatedHost.Name;
                host.Address = updatedHost.Address;
                host.UpdateTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();

                await _context.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<GetHostDto>(host);

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