using AutoMapper;
using HotelierProject.EntityLayer;
using HotelierProject.WebUI.Dtos.HotelServiceDto;

namespace HotelierProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
               CreateMap<ResultHotelServiceDto,HotelService>().ReverseMap();
               CreateMap<UpdateHotelServiceDto,HotelService>().ReverseMap();
               CreateMap<CreateHotelServiceDto,HotelService>().ReverseMap();
        }
    }
}
