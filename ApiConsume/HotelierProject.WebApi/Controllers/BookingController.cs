using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public ActionResult BookingList()
        {
           var values = _bookingService.GetListT();
            return Ok(values);
        }

        [HttpPost]
        public ActionResult AddBooking(Booking booking)
        {
            _bookingService.InsertT(booking);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteBooking(int id)
        {
            var values = _bookingService.GetByIdT(id);
            _bookingService.DeleteT(values);
            return Ok();
        }

        [HttpPut("UpdateBooking")] 
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.UpdateT(booking);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBookingById(int id)
        {
            var values = _bookingService.GetByIdT(id);
            return Ok(values);
        }

        [HttpPut("ApproveBooking")]
        public IActionResult ApproveBooking(Booking booking)
        {
            _bookingService.ChangeBookingStatusToApprovedT(booking);
            return Ok();
        }

        [HttpPut("ApproveBooking2")]
        public IActionResult ApproveBooking2(int id)
        {
            _bookingService.ChangeBookingStatusToApprovedT2(id);
            return Ok();
        }

    }
}
