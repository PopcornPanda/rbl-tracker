using AutoMapper;
using rbl_tracker.Dtos.Rbl;

namespace rbl_tracker.Services.RblServices
{
    public class RblService : IRblService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public RblService(IMapper mapper, DataContext context)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetRblDto>>> AddRbl(NewRblDto newRbl)
        {
            var serviceResponse = new ServiceResponse<List<GetRblDto>>();

            _context.Rbls.Add(_mapper.Map<Rbl>(newRbl));
            await _context.SaveChangesAsync();

            serviceResponse.Data =
                await _context.Rbls.Select(r => _mapper.Map<GetRblDto>(r)).ToListAsync();

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetRblDto>>> DeleteRbl(Guid id)
        {
            var serviceResponse = new ServiceResponse<List<GetRblDto>>();

            try
            {
                var rbl = await _context.Rbls.FirstOrDefaultAsync(r => r.Id == id);
                if (rbl is null)
                    throw new Exception($"Rbl with Id '{id}' not found");

                _context.Rbls.Remove(rbl);
                await _context.SaveChangesAsync();

                serviceResponse.Data = await
                    _context.Rbls.Select(r => _mapper.Map<GetRblDto>(r)).ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetRblDto>>> GetAllRbls()
        {
            var serviceResponse = new ServiceResponse<List<GetRblDto>>();

            serviceResponse.Data =
                await _context.Rbls.Select(r => _mapper.Map<GetRblDto>(r)).ToListAsync();

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetRblDto>> GetRblById(Guid id)
        {
            var serviceResponse = new ServiceResponse<GetRblDto>();
            var rbls = await _context.Rbls.ToListAsync();
            serviceResponse.Data = _mapper.Map<GetRblDto>(rbls.FirstOrDefault(r => r.Id == id));
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetRblDto>> GetRblByName(string name)
        {
            var serviceResponse = new ServiceResponse<GetRblDto>();
            var rbls = await _context.Rbls.ToListAsync();
            serviceResponse.Data = _mapper.Map<GetRblDto>(rbls.FirstOrDefault(r => r.Name == name));
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetRblDto>> UpdateRbl(UpdateRblDto updatedRbl)
        {
            var serviceResponse = new ServiceResponse<GetRblDto>();

            try
            {
                var rbl = await _context.Rbls.FirstOrDefaultAsync(r => r.Id == updatedRbl.Id);
                if (rbl is null)
                    throw new Exception($"Rbl with Id '{updatedRbl.Id}' not found");

                rbl.Name = updatedRbl.Name;
                rbl.Address = updatedRbl.Address;
                rbl.Type = updatedRbl.Type;
                rbl.Level = updatedRbl.Level;
                rbl.DelistUrl = updatedRbl.DelistUrl;
                rbl.UpdateTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();

                await _context.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<GetRblDto>(rbl);

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