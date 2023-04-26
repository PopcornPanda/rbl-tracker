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
                await _context.Ips.Select(r => _mapper.Map<GetIpDto>(r)).ToListAsync();

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetIpDto>>> DeleteIp(Guid id)
        {
            var serviceResponse = new ServiceResponse<List<GetIpDto>>();

            try
            {
                var ip = await _context.Ips.FirstOrDefaultAsync(r => r.Id == id);
                if (ip is null)
                    throw new Exception($"Ip with Id '{id}' not found");

                _context.Ips.Remove(ip);
                await _context.SaveChangesAsync();

                serviceResponse.Data = await
                    _context.Ips.Select(r => _mapper.Map<GetIpDto>(r)).ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetIpDto>>> GetAllIps()
        {
            var serviceResponse = new ServiceResponse<List<GetIpDto>>();

            serviceResponse.Data =
                await _context.Ips.Select(r => _mapper.Map<GetIpDto>(r)).ToListAsync();

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetIpDto>> GetIpById(Guid id)
        {
            var serviceResponse = new ServiceResponse<GetIpDto>();
            var ips = await _context.Ips.ToListAsync();
            serviceResponse.Data = _mapper.Map<GetIpDto>(ips.FirstOrDefault(r => r.Id == id));
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetIpDto>> GetIpByName(string name)
        {
            var serviceResponse = new ServiceResponse<GetIpDto>();
            var ips = await _context.Ips.ToListAsync();
            serviceResponse.Data = _mapper.Map<GetIpDto>(ips.FirstOrDefault(r => r.Name == name));
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetIpDto>>> GetIpByOwner(User user)
        {
            var serviceResponse = new ServiceResponse<List<GetIpDto>>();
            var ips = await _context.Ips.ToListAsync();
            serviceResponse.Data = _mapper.Map<List<GetIpDto>>(ips.Select(r => r.Owner == user));
            return serviceResponse;
        }


        public async Task<ServiceResponse<GetIpDto>> UpdateIp(UpdateIpDto updatedIp)
        {
            var serviceResponse = new ServiceResponse<GetIpDto>();

            try
            {
                var ip = await _context.Ips.FirstOrDefaultAsync(r => r.Id == updatedIp.Id);
                if (ip is null)
                    throw new Exception($"Ip with Id '{updatedIp.Id}' not found");

                ip.Name = updatedIp.Name;
                ip.Address = updatedIp.Address;
                ip.Owner = updatedIp.Owner;
                ip.UpdateTime = updatedIp.UpdateTime;

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