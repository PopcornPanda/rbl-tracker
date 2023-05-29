using System.Security.Claims;
using AutoMapper;
using rbl_tracker.Dtos.Check;
using System.Net;
using DnsClient;
using System.Text.RegularExpressions;

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

        public async Task<ServiceResponse<List<GetRblCheckHistoryDto>>> RblCheck(Guid userId)
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

            var hosts = await _context.Hosts.Include(i => i.Owner)
                .Where(i => i.Owner!.Id == GetUserId()).ToListAsync();
            var rbls = await _context.Rbls.Where(r => r.Type == RblType.Rbl).ToListAsync();
            var surbls = await _context.Rbls.Where(r => r.Type == RblType.Surbl).ToListAsync();

            try
            {
                if (hosts.Count != 0)
                    foreach (var host in hosts)
                    {
                        var checkResult = _mapper.Map<CheckRblHistory>(new SetRblCheckHistoryDto());
                        var revhost = String.Join(".", host.Address.Split(".").Reverse());
                        if (host.isDomain)
                        {
                            await Parallel.ForEachAsync (surbls, async (rbl, CancellationToken) =>
                            {
                                var query = await lookup.QueryAsync(host.Address + "." + rbl.Address,QueryType.A);
                                var _rblresult = query.Answers.ARecords().FirstOrDefault()?.Address;
                                if (_rblresult is not null && rbl is not null)
                                {
                                    if (isListed(_rblresult.ToString()))
                                    {
                                        checkResult.Rbls.Add(rbl);

                                        if (checkResult.Level is null || checkResult.Level < rbl.Level)
                                            checkResult.Level = rbl.Level;
                                    }
                                }
                            });
                        } else {
                            await Parallel.ForEachAsync (rbls, async (rbl, CancellationToken) =>
                            {
                                var query = await lookup.QueryAsync(revhost + "." + rbl.Address,QueryType.A);
                                var _rblresult = query.Answers.ARecords().FirstOrDefault()?.Address;
                                if (_rblresult is not null && rbl is not null)
                                {
                                    if (isListed(_rblresult.ToString()))
                                    {
                                        checkResult.Rbls.Add(rbl);

                                        if (checkResult.Level is null || checkResult.Level < rbl.Level)
                                            checkResult.Level = rbl.Level;
                                    }
                                }
                            });
                        }
                        checkResult.Host = host.Id;
                        checkResult.CheckTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
                        _context.CheckRblHistory.Add(checkResult);
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
            var hosts = await _context.Hosts.Include(i => i.Owner)
                .Where(i => i.Owner!.Id == GetUserId()).ToListAsync();

            if (hosts.Count != 0)
                foreach (var host in hosts)
                {
                    var _entry = await _context.CheckRblHistory
                        .Include(h => h.Rbls)
                        .OrderByDescending(h => h.CheckTime)
                        .Where(h => h.Host == host.Id)
                        .Select(h => _mapper.Map<GetRblCheckSimpleHistoryDto>(h))
                        .FirstAsync();
                    _entry.Host = host.Address;
                    foreach (var rblinfo in _entry.Rbls)
                        rblinfo.DelistUrl = rblinfo.DelistUrl.Replace("ADDRESS", _entry.Host);
                    serviceResponse.Data!.Add(_entry);
                }

            return serviceResponse;
        }
        
        

        private Guid GetUserId() => Guid.Parse(_httpContextAccessor.HttpContext!.User
            .FindFirstValue(ClaimTypes.NameIdentifier)!);

        private bool isListed(string ip){
            string _pattern = @"^(127)\.[0-9](\.[0-9]{1,3}){2}";
            Regex _check = new Regex(_pattern);
            return _check.IsMatch(ip, 0);  
        }

    }
}