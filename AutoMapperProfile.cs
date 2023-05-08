using AutoMapper;
using rbl_tracker.Dtos.Rbl;
using rbl_tracker.Dtos.Ip;
using rbl_tracker.Dtos.Domain;
using rbl_tracker.Dtos.Auth;
using rbl_tracker.Dtos.Check;

namespace rbl_tracker
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Rbl, GetRblDto>();
            CreateMap<Rbl, GetRblListingDto>();
            CreateMap<NewRblDto, Rbl>();

            CreateMap<Domain, GetDomainDto>();
            CreateMap<Domain, GetSimpleDomainDto>();
            CreateMap<NewDomainDto, Domain>();

            CreateMap<Ip, GetIpDto>();
            CreateMap<Ip, GetSimpleIpDto>();
            CreateMap<NewIpDto, Ip>();

            CreateMap<User, GetUserDto>();

            CreateMap<CheckRblHistory, GetRblCheckHistoryDto>();
            CreateMap<CheckRblHistory, GetRblCheckSimpleHistoryDto>();
            CreateMap<SetRblCheckHistoryDto, CheckRblHistory>();
        }
    }
}