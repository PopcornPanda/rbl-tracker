using System.Security.Claims;
using AutoMapper;
using rbl_tracker.Dtos.Check;
using System.Net;
using DnsClient;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Options;
using rbl_tracker.Configuration;
using rbl_tracker.Services.Notification;
using MimeKit;

namespace rbl_tracker.Services.CheckRblServices
{
    public class CheckRblService : ICheckRblService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ResolverSettings _settings;
        private readonly MailSettings _mail;
        private readonly INotificationService _notify;

        public CheckRblService(IMapper mapper, DataContext context, IHttpContextAccessor httpContextAccessor,
                                IOptions<ResolverSettings> settings, INotificationService notify, IOptions<MailSettings> mail)
        {
            _httpContextAccessor = httpContextAccessor;
            _settings = settings.Value;
            _mail = mail.Value;
            _context = context;
            _mapper = mapper;
            _notify = notify;
        }

        public async Task<ServiceResponse<List<GetRblCheckHistoryDto>>> RblCheck(Guid userId)
        {
            var lookup = RblLookup();
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
                        var _queryPart = (host.isDomain) ? host.Address : String.Join(".", host.Address.Split(".").Reverse());
                        var _rblList = (host.isDomain) ? surbls : rbls;

                        await Parallel.ForEachAsync(_rblList, async (rbl, CancellationToken) =>
                            {
                                var query = await lookup.QueryAsync(_queryPart + "." + rbl.Address, QueryType.A);
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

                        if (checkResult.Rbls.Any())
                        {
                            var _entry = await _context.CheckRblHistory
                                .Include(h => h.Rbls)
                                .OrderByDescending(h => h.CheckTime)
                                .Where(h => h.Host == host.Id)
                                .Select(h => _mapper.Map<GetRblCheckSimpleHistoryDto>(h))
                                .FirstOrDefaultAsync();
                            var history = _entry is not null ? _entry : new GetRblCheckSimpleHistoryDto();

                            checkResult.Host = host.Id;
                            checkResult.CheckTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
                            _context.CheckRblHistory.Add(checkResult);
                            await _context.SaveChangesAsync();

                            if (_mail.Enabled)
                                await SendEmailNotification(host, checkResult, history);
                        }
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
                        .FirstOrDefaultAsync();
                    if (_entry is not null)
                    {
                        _entry.Host = host.Address;
                        foreach (var rblinfo in _entry.Rbls)
                            rblinfo.DelistUrl = rblinfo.DelistUrl.Replace("ADDRESS", _entry.Host);
                        serviceResponse.Data!.Add(_entry);
                    }
                }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetRblCheckSimpleHistoryDto>>> RblCheckHistorySingle(Models.Host host)
        {
            var serviceResponse = new ServiceResponse<List<GetRblCheckSimpleHistoryDto>>();
            serviceResponse.Data = new List<GetRblCheckSimpleHistoryDto>();
            var _entry = await _context.CheckRblHistory
                .Include(h => h.Rbls)
                .OrderByDescending(h => h.CheckTime)
                .Where(h => h.Host == host.Id)
                .Select(h => _mapper.Map<GetRblCheckSimpleHistoryDto>(h))
                .FirstOrDefaultAsync();
            if (_entry is not null)
            {
                _entry.Host = host.Address;
                foreach (var rblinfo in _entry.Rbls)
                    rblinfo.DelistUrl = rblinfo.DelistUrl.Replace("ADDRESS", _entry.Host);
                serviceResponse.Data!.Add(_entry);
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetRblCheckHistoryDto>>> RblCheckSingle(Guid userId, Models.Host host)
        {
            var lookup = RblLookup();
            var serviceResponse = new ServiceResponse<List<GetRblCheckHistoryDto>>();
            serviceResponse.Data = new List<GetRblCheckHistoryDto>();

            var rbls = await _context.Rbls.Where(r => r.Type == RblType.Rbl).ToListAsync();
            var surbls = await _context.Rbls.Where(r => r.Type == RblType.Surbl).ToListAsync();

            try
            {
                var checkResult = _mapper.Map<CheckRblHistory>(new SetRblCheckHistoryDto());
                var _queryPart = (host.isDomain) ? host.Address : String.Join(".", host.Address.Split(".").Reverse());
                var _rblList = (host.isDomain) ? surbls : rbls;

                await Parallel.ForEachAsync(_rblList, async (rbl, CancellationToken) =>
                    {
                        var query = await lookup.QueryAsync(_queryPart + "." + rbl.Address, QueryType.A);
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

                if (checkResult.Rbls.Any())
                {
                    var _entry = await _context.CheckRblHistory
                        .Include(h => h.Rbls)
                        .OrderByDescending(h => h.CheckTime)
                        .Where(h => h.Host == host.Id)
                        .Select(h => _mapper.Map<GetRblCheckSimpleHistoryDto>(h))
                        .FirstOrDefaultAsync();
                    var history = _entry is not null ? _entry : new GetRblCheckSimpleHistoryDto();

                    checkResult.Host = host.Id;
                    checkResult.CheckTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
                    _context.CheckRblHistory.Add(checkResult);
                    await _context.SaveChangesAsync();

                    if (_mail.Enabled)
                        await SendEmailNotification(host, checkResult, history);
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        private Guid GetUserId() => Guid.Parse(_httpContextAccessor.HttpContext!.User
            .FindFirstValue(ClaimTypes.NameIdentifier)!);

        private bool isListed(string ip)
        {
            string _pattern = @"^(127)\.[0-9](\.[0-9]{1,3}){2}";
            Regex _check = new Regex(_pattern);
            return _check.IsMatch(ip, 0);
        }

        private LookupClient RblLookup()
        {
            var namesevers = new List<IPAddress>();
            var _resolversInConfig = _settings.Resolvers;
            if (_resolversInConfig is not null)
                foreach (var ns in _resolversInConfig)
                {
                    namesevers.Add(IPAddress.Parse(ns.ToString()));
                }

            var lookupOptions = new LookupClientOptions(namesevers.ToArray())
            {
                ContinueOnEmptyResponse = _settings.ContinueOnEmptyResponse,
                UseRandomNameServer = _settings.UseRandomNameServer,
                ContinueOnDnsError = _settings.ContinueOnDnsError

            };

            return new LookupClient(lookupOptions);
        }

        private BodyBuilder NotificationBody(List<Dtos.Rbl.GetRblListingDto> old, List<Rbl> cur, string host)
        {
            var _cur = _mapper.Map<List<Dtos.Rbl.GetRblListingDto>>(cur);
            var _added = _cur.Where(c => !old.Any(o => c.Name == o.Name)).ToList();
            var _removed = old.Where(o => !_cur.Any(c => o.Name == c.Name)).ToList();
            var body = new BodyBuilder();
            var mailText = EmailHelper.BuildTemplate("Templates/", "HostStatusChange.html");
            mailText = mailText.Replace("[host]", host)
                .Replace("[added]", EmailHelper.BuildList(_added))
                .Replace("[removed]", EmailHelper.BuildList(_removed))
                .Replace("ADDRESS", host);

            if (_added.Any() || _removed.Any())
            {
                body.HtmlBody = mailText;
                body.TextBody = EmailHelper.ConvertToPlainText(mailText);
            }

            return body;
        }

        private async Task SendEmailNotification(Models.Host host, CheckRblHistory checkResult, GetRblCheckSimpleHistoryDto entry)
        {
            var _oldRbls = entry is not null ? entry.Rbls : new List<Dtos.Rbl.GetRblListingDto>();
            var msg = NotificationBody(_oldRbls, checkResult.Rbls, host.Address);
            var subject = $"Status of {host.Address} have been changed on RBL!";
            if (msg.TextBody is not null)
                await _notify.SendAsync(host.Owner!.Email, msg, subject, new CancellationToken());

        }

    }
}