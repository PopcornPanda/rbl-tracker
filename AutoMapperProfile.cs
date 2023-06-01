using AutoMapper;
using rbl_tracker.Dtos.Rbl;
using rbl_tracker.Dtos.Host;
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


            CreateMap<Models.Host, GetHostDto>();
            CreateMap<Models.Host, GetSimpleHostDto>();
            CreateMap<NewHostDto, Models.Host>();

            CreateMap<User, GetUserDto>();
            CreateMap<User, GetSimpleUserDto>();

            CreateMap<CheckRblHistory, GetRblCheckHistoryDto>();
            CreateMap<CheckRblHistory, GetRblCheckSimpleHistoryDto>();
            CreateMap<SetRblCheckHistoryDto, CheckRblHistory>();
        }
    }
}