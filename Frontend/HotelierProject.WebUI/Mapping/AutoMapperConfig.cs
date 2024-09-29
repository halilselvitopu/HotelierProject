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
using HotelierProject.WebUI.Dtos.BookingDto;
using HotelierProject.WebUI.Dtos.AdminBookingDto;
using HotelierProject.WebUI.Dtos.ContactDto;
using HotelierProject.WebUI.Dtos.GuestDto;

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

               CreateMap<CreateBookingDto, Booking>().ReverseMap();

               CreateMap<ResultAdminBookingDto, Booking>().ReverseMap();

               CreateMap<ApproveBookingDto, Booking>().ReverseMap();

               CreateMap<CreateContactDto, Contact>().ReverseMap();

               CreateMap<CreateGuestDto, Guest>().ReverseMap();

               CreateMap<UpdateGuestDto, Guest>().ReverseMap();

               CreateMap<ResultAppUserDto, AppUser>().ReverseMap();
             



              
  

           
        }
    }
}
