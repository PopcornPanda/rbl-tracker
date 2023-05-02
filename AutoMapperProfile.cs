using AutoMapper;
using rbl_tracker.Dtos.Rbl;
using rbl_tracker.Dtos.Ip;
using rbl_tracker.Dtos.Domain;
using rbl_tracker.Dtos.Auth;

namespace rbl_tracker
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Rbl, GetRblDto>();
            CreateMap<NewRblDto, Rbl>();

            CreateMap<Domain, GetDomainDto>();
            CreateMap<NewDomainDto, Domain>();

            CreateMap<Ip, GetIpDto>();
            CreateMap<NewIpDto, Ip>();

            CreateMap<User, GetUserDto>();
        }
    }
}