using System.Security.Claims;
using AutoMapper;
using rbl_tracker.Dtos.Check;
using System.Net;
using DnsClient;

namespace rbl_tracker.Services.CheckRblServices
{
    public class CheckRblService : ICheckRblService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;

        public CheckRblService(IMapper mapper, DataContext context, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetRblCheckHistoryDto>>> RblCheck()
        {
            var namesevers = new List<IPAddress>();
            var _resolversInConfig = _configuration.GetSection("AppSettings:Resolvers").Get<List<string>>();
            if (_resolversInConfig is not null)
                foreach(var ns in _resolversInConfig)
                {
                    namesevers.Add(IPAddress.Parse(ns.ToString()));
                }

            var lookupOptions = new LookupClientOptions(namesevers.ToArray())
            {
                ContinueOnEmptyResponse = true,
                UseRandomNameServer = true,
                ContinueOnDnsError = true

            };

            var lookup = new LookupClient(lookupOptions);
            var serviceResponse = new ServiceResponse<List<GetRblCheckHistoryDto>>();
            serviceResponse.Data = new List<GetRblCheckHistoryDto>();

            var ips = await _context.Ips.Include(i => i.Owner)
                .Where(i => i.Owner!.Id == GetUserId()).ToListAsync();
            var domains = await _context.Domains.Include(d => d.Owner)
                .Where(i => i.Owner!.Id == GetUserId()).ToListAsync();
            var rbls = await _context.Rbls.Where(r => r.Type == RblType.Rbl).ToListAsync();
            var surbls = await _context.Rbls.Where(r => r.Type == RblType.Surbl).ToListAsync();

            try
            {
                if (ips.Count != 0)
                    foreach (var ip in ips)
                    {
                        var checkResult = _mapper.Map<CheckRblHistory>(new SetRblCheckHistoryDto());
                        var revip = String.Join(".", ip.Address.Split(".").Reverse());
                        foreach (var rbl in rbls)
                        {
                            Console.WriteLine(revip + "." + rbl.Address);
                            var query = await lookup.QueryAsync(revip + "." + rbl.Address,QueryType.A);
                            var _rblresult = query.Answers.ARecords().FirstOrDefault()?.Address;
                            Console.WriteLine(_rblresult);
                            if (_rblresult is not null && rbl is not null)
                            {
                                checkResult.Rbls.Add(rbl);

                                if (checkResult.Level is null || checkResult.Level < rbl.Level)
                                    checkResult.Level = rbl.Level;
                            }
                        };
                        checkResult.Ip = ip.Id;
                        checkResult.CheckTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
                        _context.CheckRblHistory.Add(checkResult);
                        await _context.SaveChangesAsync();
                    };

                if (domains.Count != 0)
                    foreach (var domain in domains)
                    {
                        var checkResult = _mapper.Map<CheckRblHistory>(new SetRblCheckHistoryDto());
                        foreach (var rbl in surbls)
                        {
                            var query = await lookup.QueryAsync(domain.Address + "." + rbl.Address,QueryType.A);
                            var _rblresult = query.Answers.ARecords().FirstOrDefault()?.Address;
                            if (_rblresult is not null && rbl is not null)
                            {
                                checkResult.Rbls.Add(rbl);

                                if (checkResult.Level is null || checkResult.Level < rbl.Level)
                                    checkResult.Level = rbl.Level;
                            }
                        }
                        checkResult.Domain = domain.Id;
                        checkResult.CheckTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
                        await _context.SaveChangesAsync();
                    };
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetRblCheckSimpleHistoryDto>>> RblCheckHistory()
        {
            var serviceResponse = new ServiceResponse<List<GetRblCheckSimpleHistoryDto>>();
            serviceResponse.Data = new List<GetRblCheckSimpleHistoryDto>();
            var ips = await _context.Ips.Include(i => i.Owner)
                .Where(i => i.Owner!.Id == GetUserId()).ToListAsync();
            var domains = await _context.Domains.Include(d => d.Owner)
                .Where(i => i.Owner!.Id == GetUserId()).ToListAsync();

            if (ips.Count != 0)
                foreach (var ip in ips)
                {
                    var _entry = await _context.CheckRblHistory
                        .Include(h => h.Rbls)
                        .OrderByDescending(h => h.CheckTime)
                        .Where(h => h.Ip == ip.Id)
                        .Select(h => _mapper.Map<GetRblCheckSimpleHistoryDto>(h))
                        .FirstAsync();
                    _entry.Ip = ip.Address;
                    foreach (var rblinfo in _entry.Rbls)
                        rblinfo.DelistUrl = rblinfo.DelistUrl.Replace("ADDRESS", _entry.Ip);
                    serviceResponse.Data!.Add(_entry);
                }
            if (domains.Count != 0)
                foreach (var domain in domains)
                {
                    var _entry = await _context.CheckRblHistory
                        .Include(h => h.Rbls)
                        .OrderByDescending(h => h.CheckTime)
                        .Where(h => h.Domain == domain.Id)
                        .Select(h => _mapper.Map<GetRblCheckSimpleHistoryDto>(h))
                        .FirstAsync();
                    _entry.Domain = domain.Address;
                    foreach (var rblinfo in _entry.Rbls)
                       rblinfo.DelistUrl = rblinfo.DelistUrl.Replace("ADDRESS", _entry.Domain);
                    serviceResponse.Data!.Add(_entry);
                }

            return serviceResponse;
        }

        private Guid GetUserId() => Guid.Parse(_httpContextAccessor.HttpContext!.User
            .FindFirstValue(ClaimTypes.NameIdentifier)!);

    }
}