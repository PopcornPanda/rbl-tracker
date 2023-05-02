using System.Security.Claims;
using AutoMapper;
using rbl_tracker.Dtos.Domain;

namespace rbl_tracker.Services.DomainServices
{
    public class DomainService : IDomainService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DomainService(IMapper mapper, DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _mapper = mapper;
        }
        private Guid GetUserId() => Guid.Parse(_httpContextAccessor.HttpContext!.User
            .FindFirstValue(ClaimTypes.NameIdentifier)!);
        public async Task<ServiceResponse<List<GetDomainDto>>> AddDomain(NewDomainDto newDomain)
        {
            var serviceResponse = new ServiceResponse<List<GetDomainDto>>();
            var domain = _mapper.Map<Domain>(newDomain);
            domain.Owner = await _context.Users.FirstOrDefaultAsync(u => u.Id == GetUserId());

            _context.Domains.Add(domain);
            await _context.SaveChangesAsync();

            serviceResponse.Data =
                await _context.Domains
                .Where(d => d.Owner!.Id == GetUserId())
                .Select(d => _mapper.Map<GetDomainDto>(d))
                .ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetDomainDto>>> DeleteDomain(Guid id)
        {
            var serviceResponse = new ServiceResponse<List<GetDomainDto>>();

            try
            {
                var domain = await _context.Domains.FirstOrDefaultAsync(d => d.Id == id && d.Owner!.Id == GetUserId());
                if (domain is null)
                    throw new Exception($"Domain with Id '{id}' not found");

                _context.Domains.Remove(domain);
                await _context.SaveChangesAsync();

                serviceResponse.Data = await
                    _context.Domains
                    .Where(d => d.Owner!.Id == GetUserId())
                    .Select(d => _mapper.Map<GetDomainDto>(d))
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetDomainDto>>> GetAllDomains(Guid ownerId)
        {
            var serviceResponse = new ServiceResponse<List<GetDomainDto>>();
            var domains = await _context.Domains.Include(d => d.Owner)
                .Where(d => d.Owner!.Id == GetUserId()).ToListAsync();
            serviceResponse.Data =
                domains.Select(d => _mapper.Map<GetDomainDto>(d)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetDomainDto>> GetDomainById(Guid id)
        {
            var serviceResponse = new ServiceResponse<GetDomainDto>();
            var domains = await _context.Domains.Include(d => d.Owner)
                .Where(d => d.Owner!.Id == GetUserId()).ToListAsync();
            serviceResponse.Data = _mapper.Map<GetDomainDto>(domains.FirstOrDefault(d => d.Id == id));
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetDomainDto>> GetDomainByName(string name)
        {
            var serviceResponse = new ServiceResponse<GetDomainDto>();
            var domains = await _context.Domains.Include(d => d.Owner)
                .Where(d => d.Owner!.Id == GetUserId()).ToListAsync();
            serviceResponse.Data = _mapper.Map<GetDomainDto>(domains.FirstOrDefault(d => d.Name == name));
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetDomainDto>> UpdateDomain(UpdateDomainDto updatedDomain)
        {
            var serviceResponse = new ServiceResponse<GetDomainDto>();

            try
            {
                var domain = await _context.Domains.Include(d => d.Owner)
                .FirstOrDefaultAsync(d => d.Id == updatedDomain.Id && d.Owner!.Id == GetUserId());
                if (domain is null || domain.Owner!.Id != GetUserId())
                    throw new Exception($"Domain with Id '{updatedDomain.Id}' not found");

                domain.Name = updatedDomain.Name;
                domain.Address = updatedDomain.Address;
                domain.UpdateTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();

                await _context.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<GetDomainDto>(domain);

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