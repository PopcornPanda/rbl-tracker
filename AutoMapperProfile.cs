using AutoMapper;
using rbl_tracker.Dtos.Rbl;
using rbl_tracker.Dtos.Ip;
using rbl_tracker.Dtos.Domain;

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
        }
    }
}