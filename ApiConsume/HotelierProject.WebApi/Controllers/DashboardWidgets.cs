using HotelierProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgets : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IAppUserService _appUserService;
        private readonly IRoomService _roomService;

        public DashboardWidgets(IStaffService staffService, IBookingService bookingService, IAppUserService appUserService, IRoomService roomService)
        {
            _staffService = staffService;
            _bookingService = bookingService;
            _appUserService = appUserService;
            _roomService = roomService;
        }

        [HttpGet("GetStaffCount")]
        public IActionResult GetStaffCount()
        {
            var value = _staffService.GetStaffCountT();
            return Ok(value);
        }

        [HttpGet("GetBookingCount")]
        public IActionResult GetBookingCount()
        {
            var value = _bookingService.GetBookingCountT();
            return Ok(value);
        }

        [HttpGet("GetAppUserCount")]
        public IActionResult GetAppUserCount()
        {
            var value = _appUserService.GetAppUserCountT();
            return Ok(value);
        }

        [HttpGet("GetRoomCount")]
        public IActionResult GetRoomCount()
        {
            var value = _roomService.GetRoomCountT();
            return Ok(value);
        }
    }
}
