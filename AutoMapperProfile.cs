using AutoMapper;
using rbl_tracker.Dtos.Rbl;

namespace rbl_tracker
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Rbl, GetRblDto>();
            CreateMap<NewRblDto, Rbl>();
        }
    }
}