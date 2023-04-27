using AutoMapper;
using rbl_tracker.Dtos.Ip;

namespace rbl_tracker.Services.IpServices
{
    public class IpService : IIpService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public IpService(IMapper mapper, DataContext context)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetIpDto>>> AddIp(NewIpDto newIp)
        {
            var serviceResponse = new ServiceResponse<List<GetIpDto>>();

            _context.Ips.Add(_mapper.Map<Ip>(newIp));
            await _context.SaveChangesAsync();

            serviceResponse.Data =
                await _context.Ips.Select(i => _mapper.Map<GetIpDto>(i)).ToListAsync();

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetIpDto>>> DeleteIp(Guid id)
        {
            var serviceResponse = new ServiceResponse<List<GetIpDto>>();

            try
            {
                var ip = await _context.Ips.FirstOrDefaultAsync(i => i.Id == id);
                if (ip is null)
                    throw new Exception($"Ip with Id '{id}' not found");

                _context.Ips.Remove(ip);
                await _context.SaveChangesAsync();

                serviceResponse.Data = await
                    _context.Ips.Select(i => _mapper.Map<GetIpDto>(i)).ToListAsync();
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
            var ips = await _context.Ips.Where(i => i.Owner!.Id == ownerId).ToListAsync();
            serviceResponse.Data =
                ips.Select(i => _mapper.Map<GetIpDto>(i)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetIpDto>> GetIpById(Guid id)
        {
            var serviceResponse = new ServiceResponse<GetIpDto>();
            var ips = await _context.Ips.ToListAsync();
            serviceResponse.Data = _mapper.Map<GetIpDto>(ips.FirstOrDefault(i => i.Id == id));
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetIpDto>> GetIpByName(string name)
        {
            var serviceResponse = new ServiceResponse<GetIpDto>();
            var ips = await _context.Ips.ToListAsync();
            serviceResponse.Data = _mapper.Map<GetIpDto>(ips.FirstOrDefault(i => i.Name == name));
            return serviceResponse;
        }


        public async Task<ServiceResponse<GetIpDto>> UpdateIp(UpdateIpDto updatedIp)
        {
            var serviceResponse = new ServiceResponse<GetIpDto>();

            try
            {
                var ip = await _context.Ips.FirstOrDefaultAsync(i => i.Id == updatedIp.Id);
                if (ip is null)
                    throw new Exception($"Ip with Id '{updatedIp.Id}' not found");

                ip.Name = updatedIp.Name;
                ip.Address = updatedIp.Address;
                ip.Owner = updatedIp.Owner;
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