using AutoMapper;
using HotelierProject.EntityLayer;
using HotelierProject.EntityLayer.Concrete;
using HotelierProject.WebUI.Dtos.AboutDto;
using HotelierProject.WebUI.Dtos.AppUserDto;
using HotelierProject.WebUI.Dtos.HotelServiceDto;
using HotelierProject.WebUI.Dtos.NewsletterDto;
using HotelierProject.WebUI.Dtos.RoomDto;
using HotelierProject.WebUI.Dtos.StaffDto;
using HotelierProject.WebUI.Dtos.TestimonialDto;

namespace HotelierProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
               CreateMap<ResultHotelServiceDto,HotelService>().ReverseMap();
               CreateMap<UpdateHotelServiceDto,HotelService>().ReverseMap();
               CreateMap<CreateHotelServiceDto,HotelService>().ReverseMap();

               CreateMap<CreateNewAppUserDto, AppUser>().ReverseMap();
               CreateMap<LoginAppUserDto, AppUser>().ReverseMap();

               CreateMap<ResultAboutDto, About>().ReverseMap();
               CreateMap<UpdateAboutDto, About>().ReverseMap();

               CreateMap<ResultRoomDto, Room>().ReverseMap();

               CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

               CreateMap<ResultStaffDto, Staff>().ReverseMap();

               CreateMap<CreateNewsletterDto, Newsletter>().ReverseMap();

              
  

           
        }
    }
}
