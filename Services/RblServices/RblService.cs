using AutoMapper;
using rbl_tracker.Dtos.Rbl;

namespace rbl_tracker.Services.RblServices
{
    public class RblService : IRblService
    {
        private static List<Rbl> rbls = new List<Rbl>{
            new Rbl(),
            new Rbl {Name = "cbl", Address = "cbl.abuseat.org"}
        };
        private readonly IMapper _mapper;

        public RblService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetRblDto>>> AddRbl(NewRblDto newRbl)
        {
            var serviceResponse = new ServiceResponse<List<GetRblDto>>();
            rbls.Add(_mapper.Map<Rbl>(newRbl));
            serviceResponse.Data = rbls.Select(r => _mapper.Map<GetRblDto>(r)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetRblDto>>> GetAllRbls()
        {
            var serviceResponse = new ServiceResponse<List<GetRblDto>>();
            serviceResponse.Data = rbls.Select(r => _mapper.Map<GetRblDto>(r)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetRblDto>> GetRblById(Guid id)
        {
            var serviceResponse = new ServiceResponse<GetRblDto>();
            serviceResponse.Data = _mapper.Map<GetRblDto>(rbls.FirstOrDefault(r => r.Id == id));
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetRblDto>> UpdateRbl(UpdateRblDto updatedRbl)
        {
            var serviceResponse = new ServiceResponse<GetRblDto>();

            try
            {
                var rbl = _mapper.Map<GetRblDto>(rbls.FirstOrDefault(r => r.Id == updatedRbl.Id));
                if (rbl is null)
                    throw new Exception($"Rbl with Id '{updatedRbl.Id}' not found");

                rbl.Name = updatedRbl.Name;
                rbl.Address = updatedRbl.Address;
                rbl.Type = updatedRbl.Type;
                rbl.Level = updatedRbl.Level;
                rbl.DelistUrl = updatedRbl.DelistUrl;

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