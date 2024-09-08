using AutoMapper;
using HotelierProject.DtoLayer.Dtos.RoomDto;
using HotelierProject.EntityLayer;

namespace HotelierProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateRoomDto, Room>();
            CreateMap<Room, CreateRoomDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
